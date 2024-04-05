using Bridge.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Renderer
{
    public class BitmapRenderer : ShapeRenderer
    {
        public BitmapRenderer() { }
        public BitmapRenderer(IShape shape) : base(shape){ }

        public override void Render()
        {
            Console.WriteLine($"Rendering as bitmap: {shape?.GetRenderInfo()}");
        }
    }
}
