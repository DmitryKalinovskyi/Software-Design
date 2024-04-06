using Bridge.Shapes;

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
