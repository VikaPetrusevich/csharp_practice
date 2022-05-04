using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorycleConfiguration
{
    public class Motorcycle
    {
        private int _mileage;
        
        public string Code { get; } = Guid.NewGuid().ToString();

        public string Model { get; set; }

        public string Manufacturer { get; set; }

        public DateOnly Release { get; } = DateOnly.FromDateTime(DateTime.Now);

        public Engine Engine { get; set; }

        public int Mileage
        {
            get { return _mileage; }
            set
            {
                if (value > 100)
                {
                    Console.WriteLine("Mileage must not exceed 100");
                }
                else
                {
                    _mileage = value;
                }
            }
        }

        public Motorcycle(string model, string manufacturer, int mileage, Engine engine)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Mileage = mileage;
            this.Engine = engine;
        }

        protected void Reset()
        {
            Mileage = 0;
        }

        public override string ToString()
        {
            return $"\nManufacturer: {Manufacturer}, model: {Model}, code: {Code}, year of issue: {Release.Year}." +
                $"\nEngite type: {Engine.EngineType}, engine volume: {Engine.EngineVolume}, engine power: {Engine.EnginePower}";
        }
    }
}