using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double side1;
            double side2;
            Console.Write("1 сторона:");
            side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2 сторона:");
            side2 = Convert.ToDouble(Console.ReadLine());
            Rectangle rectangle = new Rectangle(side1, side2);
            rectangle.PerimeterCalculator();
            rectangle.AreaCalculator();
            Console.WriteLine($"Периметр - {rectangle.Perimeter}");
            Console.WriteLine($"Площа - {rectangle.Area}");
        }
    }
}
