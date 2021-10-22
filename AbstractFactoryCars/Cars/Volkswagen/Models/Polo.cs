using AbstractFactoryCars.Cars.Volkswagen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryCars.Cars.Volkswagen
{
    class Polo : VolkswagenCar
    {
        public Polo()
        {

            this.Capacity = 5;
            this.MaxSpeed = 120;
        }
    }
}
