using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryCars.Cars.Volkswagen
{
    class T4 : VolkswagenCar
    {
        public T4()
        {
            Capacity = 7;
            MaxSpeed = 190;
        }
    }
}
