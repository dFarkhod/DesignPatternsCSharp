using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Car hondaCity = new Honda();
            hondaCity.Model = "City";
            hondaCity.Price = 50000;

            Honda hondaCityClone = (Honda)hondaCity.Clone();
            Console.WriteLine(hondaCityClone.Price);

            Console.ReadKey();
        }
    }
}
