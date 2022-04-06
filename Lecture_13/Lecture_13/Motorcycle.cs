using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motorycle_Configuration
{
    internal class Motorcycle
    {
        public string Code { get; set; }

        public string Model { get; set; }

        public string Manufacturer { get; set; }

        public DateOnly DateOnly { get; set; }

        public int Run { get; set; }

        public void RetrieveInformation()
        {
            Console.WriteLine("\nInformatoin:");
            Console.WriteLine($"Code: {Code}.");
            Console.WriteLine($"Model: {Model}.");
            Console.WriteLine($"Manufacturer: {Manufacturer}.");
            Console.WriteLine($"Year of issue: {DateOnly}.");
            Console.WriteLine($"Mileage: {Run}.");
        }
    }
}