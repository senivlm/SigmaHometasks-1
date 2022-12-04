using Hometask6;
using Newtonsoft.Json;

System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("EN-US");

var account = new ElectricityAccount("electricity-bills.json", "quarter.txt");
var apartmentWithoutElectricity = account.GetApartmentWithoutElectricity();
Console.WriteLine(apartmentWithoutElectricity);
account.PrintApartmentsToFileAsync();
account.PrintApartmentToFileAsync(1);