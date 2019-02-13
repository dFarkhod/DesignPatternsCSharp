using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public abstract class Shape
    {
        protected IRenderer Renderer { get; set; }
        public string Colour { set; get; }

        public Shape(IRenderer renderer)
        {
            this.Renderer = renderer;
        }

        public abstract void Draw();

    }
}
