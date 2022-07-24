namespace NS.SOLID.LSP.Solution
{
    public abstract class Parallelogram
    {
        protected Parallelogram(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public double Height { get; private set; }
        public double Width { get; private set; }
        public double Area => Height * Width;
    }
}
