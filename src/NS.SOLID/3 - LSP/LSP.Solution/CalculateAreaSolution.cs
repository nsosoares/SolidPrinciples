namespace NS.SOLID.LSP.Solution
{
    public class CalculateAreaSolution
    {
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
            var rectangle = new Rectangle(10, 10);
            GetAreaValueRetangle(rectangle);
        }
    }
}
