using MotorycleConfiguration;

var engine = new BenzinEngine(150, 250);

var engine2 = new ElectricEngine(180, 300);

var engine3 = new BenzinEngine(1000, 280);


var moto = new Motorcycle("R 18 Transcontinental", "BMW", 60, engine);

var moto2 = new Motorcycle("Tesla electric bike", "Tesla", 85, engine2);

var moto3 = new Motorcycle("GL1800", "Honda", 100, engine3);

var motos = new[] { moto, moto2, moto3 };

foreach (var item in motos) 
{
    Console.WriteLine(item.ToString());
}

Console.ReadKey();