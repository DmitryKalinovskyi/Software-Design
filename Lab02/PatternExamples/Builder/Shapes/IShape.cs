namespace Builder.Shapes
{
    public interface IShape
    {
        string Name { get; set; }
        List<Vertex> GetVertices();
    }
}
