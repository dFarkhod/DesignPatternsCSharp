using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern
{
    public class ConcreteSubject : AbstractSubject
    {
        public override void Request()
        {
            Console.WriteLine($"{this.GetType().Name}->{MethodBase.GetCurrentMethod().Name} has been called.");
        }
    }
}
