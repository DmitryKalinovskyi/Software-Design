using Bridge.Renderer;
using Bridge.Shapes;


var circle = new Circle();
var rectangle = new Rectangle();
var triangle = new Triangle();


ShapeRenderer bitmapRenderer = new BitmapRenderer(circle);
bitmapRenderer.Render();

ShapeRenderer bitmapRenderer2 = new BitmapRenderer(rectangle);
bitmapRenderer2.Render();

ShapeRenderer vectorRenderer = new VectorRenderer(triangle);
vectorRenderer.Render();


/* In this context bridge pattern allow user to separate the render process with definition of shapes.
 * 
 */