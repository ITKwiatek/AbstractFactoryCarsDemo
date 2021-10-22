using AbstractFactoryCars.Cars.Volkswagen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryCars.Cars.Volkswagen
{
    class Scirocco : VolkswagenCar
    {
        public Scirocco()
        {
            Capacity = 4;
            MaxSpeed = 220;
        }
    }
}
