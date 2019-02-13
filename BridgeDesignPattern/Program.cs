using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            IRenderer renderer = new RastrRenderer();
            Shape myCircle = new Circle(renderer, "Green");
            myCircle.Draw();
            Console.ReadLine();
        }
    }
}
