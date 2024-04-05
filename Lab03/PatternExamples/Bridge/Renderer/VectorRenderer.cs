using Bridge.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Renderer
{
    public class VectorRenderer : ShapeRenderer
    {
        public VectorRenderer() { }
        public VectorRenderer(IShape shape) : base(shape) { }

        public override void Render()
        {
            Console.WriteLine($"Render as vector image: {shape?.GetRenderInfo()}");
        }
    }
}
