using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryCars.Cars.Toyota
{
    class Yaris : ToyotaCar
    {
        public Yaris()
        {
            Capacity = 5;
            MaxSpeed = 140;
        }
    }
}
