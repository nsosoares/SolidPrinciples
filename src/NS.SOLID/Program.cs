using NS.SOLID.LSP.Solution;
using NS.SOLID.LSP.Violation;

namespace NS.SOLID
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            CalculateArea.Calculate();
            CalculateAreaSolution.Calculate();
        }
    }
}
