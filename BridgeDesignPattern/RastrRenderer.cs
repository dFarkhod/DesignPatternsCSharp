using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class RastrRenderer : IRenderer
    {
        public void RenderShapre(string shapeName, string colour)
        {
            Console.WriteLine($"{this.GetType().Name} is rendering {shapeName} with {colour} color");
        }
    }
}
