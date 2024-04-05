// See https://aka.ms/new-console-template for more information
using Bridge.Renderer;
using Bridge.Shapes;


var circle = new Circle();
var rectangle = new Rectangle();
var triangle = new Triangle();


IShapeRenderer bitmapRenderer = new BitmapRenderer(circle);
bitmapRenderer.Render();

IShapeRenderer bitmapRenderer2 = new BitmapRenderer(rectangle);
bitmapRenderer2.Render();

IShapeRenderer vectorRenderer = new VectorRenderer(triangle);
vectorRenderer.Render();


