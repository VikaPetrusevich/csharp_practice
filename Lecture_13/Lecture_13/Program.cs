using Motorycle_Configuration;

Motorcycle moto = new Motorcycle();
{
    string Code = Guid.NewGuid().ToString();
    string Model = "Honda";
    string Manufacturer = "Japan";
    DateOnly Year of issue = new DateOnly();
    int Mileage = 100;
};

var moto = new[] {moto};

foreach (var item in moto)
{
    item.RetrieveInformation();
}