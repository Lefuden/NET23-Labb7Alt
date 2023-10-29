//Daniel Frykman .NET23
namespace Labb7Variation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new();
            circle.PrintData();

            Square square = new();
            square.PrintData();

            Rectangle rectangle = new(3.3);
            rectangle.PrintData();

            Parallelogram parallelogram = new(5.9);
            parallelogram.PrintData();

            Ellipse ellipse = new(5);
            ellipse.PrintData();
        }
    }
}