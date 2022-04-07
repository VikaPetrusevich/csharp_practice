using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorycleConfiguration
{
    public class BenzinEngine : Engine
    {
        public BenzinEngine(int engineVolume, int enginePower) : base(engineVolume, enginePower)
        {

        }

        public override string EngineType { get; } = "Benzin";
    }
}
