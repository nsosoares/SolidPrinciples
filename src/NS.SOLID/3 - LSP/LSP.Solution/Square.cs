namespace NS.SOLID.LSP.Solution
{
    public class Square : Parallelogram
    {
        public Square(double height, double width) 
            : base(height, width)
        {
            if (height != width)
                throw new Exception("Height and width must be equal.");
        }
    }
}
