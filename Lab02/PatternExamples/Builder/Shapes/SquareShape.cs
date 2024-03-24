namespace Builder.Shapes
{
    public class SquareShape : IShape
    {
        private List<Vertex> _vertices;
        public string Name { get; set; }

        public SquareShape()
        {
            Name = string.Empty;
            // load model from file.

            _vertices = new List<Vertex>()
            {
                new Vertex(0, 0, 0),
                new Vertex(0, 0, 1),
                new Vertex(0, 1, 0),
                new Vertex(0, 1, 1),
                new Vertex(1, 0, 0),
                new Vertex(1, 0, 1),
                new Vertex(1, 1, 0),
                new Vertex(1, 1, 1),
            };
        }


        public List<Vertex> GetVertices()
        {
            return _vertices;
        }
    }
}
