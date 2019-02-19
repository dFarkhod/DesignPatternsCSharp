using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern
{
    public class Honda : Car
    {
        public override object Clone()
        {
            return (Honda)this.MemberwiseClone();
        }

        public override void Honk()
        {
            Console.WriteLine("Beeep!");
        }
    }
}
