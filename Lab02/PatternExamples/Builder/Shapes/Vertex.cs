namespace Builder.Shapes
{
    public struct Vertex
    {
        public double X;
        public double Y;
        public double Z;

        public Vertex() : this(0, 0, 0) { }

        public Vertex(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}
