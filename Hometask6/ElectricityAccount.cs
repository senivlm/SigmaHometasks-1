using System.Text;
using System.Text.Json;
using Newtonsoft.Json;

namespace Hometask6;

public class ElectricityAccount
{
    public List<ElectricityBill> ElectricityBills { get; private set; }
    public int ApartmentsCount => ElectricityBills.Count;
    
    private uint _quarter;
    public uint Quarter
    {
        get => _quarter;
        set
        {
            if (value >= 1 || value <= 3)
            {
                _quarter = value;
                return;
            }
            Console.WriteLine("Quarter should be less than 4 and bigger than 0");
        }
    }

    public ElectricityAccount(List<ElectricityBill> bills) => ElectricityBills = bills;
    
    public ElectricityAccount(string filePath, string quarterFilePath) => 
        Task.Run(() => LoadFromFileAsync(filePath, quarterFilePath)).Wait();

    public ElectricityBill GetApartmentWithoutElectricity() =>
        ElectricityBills.SingleOrDefault(t => t.CounterData.ContainsValue(0));

    public async Task PrintApartmentToFileAsync(uint apartmentNumber)
    {
        var apartment = ElectricityBills.SingleOrDefault(t => t.ApartmentNumber == apartmentNumber);
        var fileName = $"apartment-number-{apartmentNumber}.txt";
        await File.WriteAllTextAsync(fileName, apartment.ToString());
        Console.WriteLine($"Info about apartment №{apartmentNumber} printed into file: {fileName}");
    }
    
    public async Task PrintApartmentsToFileAsync()
    {
        var fileName = $"apartments.txt";
        var apartmentsString = string.Join('\n', ElectricityBills.Select(t => t.ToString() + '\n'));
        await File.WriteAllTextAsync(fileName, apartmentsString);
        Console.WriteLine($"Info about all apartments printed into file: {fileName}");
    }

    public async Task LoadFromFileAsync(string filePath, string quarterFilePath)
    {
        var quarterString = await File.ReadAllTextAsync(quarterFilePath);
        Quarter = Convert.ToUInt32(quarterString);
        var json = await File.ReadAllTextAsync(filePath);
        ElectricityBills = JsonConvert.DeserializeObject<List<ElectricityBill>>(json);
    }

    public async Task SaveToFileAsync()
    {
        var json = JsonConvert.SerializeObject(ElectricityBills);
        await File.WriteAllTextAsync("electricity-bills.json", json);
    }
}