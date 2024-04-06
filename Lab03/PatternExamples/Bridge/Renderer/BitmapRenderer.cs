using Bridge.Shapes;

namespace Bridge.Renderer
{
    public class BitmapRenderer : ShapeRenderer
    {
        public BitmapRenderer() { }
        public BitmapRenderer(IShape shape) : base(shape) { }

        public override void Render()
        {
            Console.WriteLine($"Rendering as bitmap: {shape?.GetRenderInfo()}");
        }
    }
}
