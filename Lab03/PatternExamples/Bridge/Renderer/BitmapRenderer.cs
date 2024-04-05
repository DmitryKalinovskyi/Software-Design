using Bridge.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Renderer
{
    public class BitmapRenderer : IShapeRenderer
    {
        protected IShape _shape;

        public BitmapRenderer(IShape shape)
        {
            _shape = shape;
        }

        public void Render()
        {
            Console.WriteLine($"Rendering as bitmap: {_shape.GetRenderInfo()}");
        }
    }
}
