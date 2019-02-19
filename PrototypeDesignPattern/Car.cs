using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern
{
    public abstract class Car : ICloneable
    {
        public string Model { get; set; }
        public decimal Price { get; set; }
        public abstract void Honk();
        public abstract object Clone();
       
    }
}
