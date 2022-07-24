namespace NS.SOLID.LSP.Violation
{
    public class CalculateArea
    {
        /*
         This class implements the LSP but due to the change in 
         behavior of the rectangle base class in the square class 
         it ends up generating a bug
         */

        private static void GetAreaValueRetangle(Rectangle rectangle)
        {
            Console.Clear();
            Console.WriteLine("Calculate the area of the rectangle");
            Console.WriteLine();
            Console.WriteLine(rectangle.Height + " * " + rectangle.Width);
            Console.WriteLine();
            Console.WriteLine(rectangle.Area);
            Console.ReadKey();
        }

        public static void Calculate()
        {
            var square = new Square
            {
                Height = 10,
                Width = 5
            };
            GetAreaValueRetangle(square);
        }
    }
}
