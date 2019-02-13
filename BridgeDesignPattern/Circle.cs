using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Circle : Shape
    {
        public Circle(IRenderer renderer, string colour) : base(renderer)
        {
            this.Colour = colour;
        }
        
        public override void Draw()
        {
            this.Renderer.RenderShapre(this.GetType().Name, base.Colour);
        }
    }
}
