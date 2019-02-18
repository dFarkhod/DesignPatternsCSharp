using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern
{
    public class Proxy : AbstractSubject
    {
        private ConcreteSubject subject = null;

        public override void Request()
        {
            if (subject == null)
                subject = new ConcreteSubject();

            subject.Request();
        }
    }
}
