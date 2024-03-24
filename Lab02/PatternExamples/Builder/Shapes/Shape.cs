namespace Builder.Shapes
{
    public class Shape : IShape
    {
        private List<Vertex> _vertices;

        public string Name { get; set; }

        public Shape() : this(string.Empty) { }

        public Shape(string name)
        {
            Name = name;
            _vertices = new();
        }

        public Shape(string name, List<Vertex> vertices)
        {
            Name = name;
            _vertices = vertices;
        }

        public List<Vertex> GetVertices()
        {
            return _vertices;
        }
    }
}
