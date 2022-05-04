using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorycleConfiguration
{
    public abstract class Engine
    {
        private string _engineType;

        private int _engineVolume;

        private int _enginePower;

        public abstract string EngineType { get; }

        public int EngineVolume
        {
            get { return _engineVolume; }
            set
            {
                if (value < 125 && value > 1300)
                {
                    Console.WriteLine("Engine volume is wrong.");
                }
                else
                {
                    _engineVolume = value;
                }
            }
        }

        public int EnginePower
        {
            get { return _enginePower; }
            set
            {
                if (value < 50 && value > 400)
                {
                    Console.WriteLine("Engine power is wrong.");
                }
                else
                {
                    _enginePower = value;
                }
            }
        }
        public Engine(int engineVolume, int enginePower)
        {
            this.EngineVolume = engineVolume;
            this.EnginePower = enginePower;
        }
    }
}