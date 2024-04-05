using Bridge.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Renderer
{
    public abstract class ShapeRenderer
    {
        protected IShape? shape;

        public ShapeRenderer() { }

        public ShapeRenderer(IShape shape)
        {
            this.shape = shape;
        }

        public abstract void Render();
    }
}
