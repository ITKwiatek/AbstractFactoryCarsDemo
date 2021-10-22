using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryCars
{
    public abstract class Car
    {
        internal int Capacity;
        internal int MaxSpeed;
        internal string FactoryName;
        public string GetData()
        {
            return this.GetType().Name;
        }
        public void Describe()
        {
            Console.WriteLine($"Factory: {FactoryName}, Model: {GetData()}, Capacity: {Capacity}, Max speed: {MaxSpeed}.");
        }
    }
}
