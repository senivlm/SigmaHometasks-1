namespace Hometask6;

public class ElectricityBill
{
    public uint ApartmentNumber { get; set; }
    public string Address { get; set; }
    public string OwnerSurname { get; set; }
    public Dictionary<DateOnly, uint> CounterData { get; set; }
    
    public ElectricityBill(){}

    public ElectricityBill(uint apartmentNumber, string address, string ownerSurname,
                           Dictionary<DateOnly, uint> counterData)
    {
        ApartmentNumber = apartmentNumber;
        Address = address;
        OwnerSurname = ownerSurname;
        CounterData = counterData;
    }

    public ElectricityBill(uint apartmentNumber, string address, string ownerSurname)
    {
        ApartmentNumber = apartmentNumber;
        Address = address;
        OwnerSurname = ownerSurname;
        CounterData = new Dictionary<DateOnly, uint>();
    }

    public override string ToString()
    {
        var list = CounterData.Select(t => $"date: {t.Key.ToWrittenDateOnly()}\tdata: {t.Value}");
        var counterData = string.Join('\n', list);
        return $"Apartment number: {ApartmentNumber}\t" +
               $"Address: {Address}\t" +
               $"Owner surname: {OwnerSurname}\n" +
               $"Counter data:\n{counterData}\n";
    } 
}