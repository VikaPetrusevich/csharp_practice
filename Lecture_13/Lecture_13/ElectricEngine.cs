using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorycleConfiguration
{
    public class ElectricEngine : Engine
    {
        public ElectricEngine(int engineVolume, int enginePower) : base(engineVolume, enginePower)
        {

        }

        public override string EngineType { get; } = "Electric";
    }
}
