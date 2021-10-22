using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryCars.Cars.Toyota
{
    class Supra : ToyotaCar
    {
        public Supra()
        {
            Capacity = 4;
            MaxSpeed = 300;
        }
    }
}
