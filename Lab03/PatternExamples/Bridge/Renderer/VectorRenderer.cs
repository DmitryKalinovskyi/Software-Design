using Bridge.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Renderer
{
    public class VectorRenderer : IShapeRenderer
    {
        protected IShape _shape;

        public VectorRenderer(IShape shape)
        {
            _shape = shape;
        }

        public void Render()
        {
            Console.WriteLine($"Render as vector image: {_shape.GetRenderInfo()}");
        }
    }
}
