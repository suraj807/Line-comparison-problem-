using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_comparison_problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to line comparison problem");

            double X1, X2;
            double Y1, Y2;
            double x1, x2;
            double y1, y2;
            double Lengthline1, Lengthline2;


            Console.WriteLine("Enter first point X coordinate x1: ");
            X1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter first point Y coordinate y1: ");
            Y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second point X coordinate x2: ");
            X2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second point Y coordinate y2: ");
            Y2 = Convert.ToDouble(Console.ReadLine());

            double Xpower = Math.Pow((X2 - X1), 2);
            double Ypower = Math.Pow((Y2 - Y1), 2);

            Lengthline1 = Math.Sqrt((Xpower + Ypower));

            Console.WriteLine($"Length of line using two points ({X1},{X1}) and ({Y2},{Y2}) is : {Lengthline1}");




            Console.WriteLine("Enter first point X coordinate x1: ");
            x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter first point Y coordinate y1: ");
            y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second point X coordinate x2: ");
            x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second point Y coordinate y2: ");
            y2 = Convert.ToDouble(Console.ReadLine());

            double xpower = Math.Pow((x2 - x1), 2);
            double ypower = Math.Pow((y2 - y1), 2);

            Lengthline2 = Math.Sqrt((xpower + ypower));


            Console.WriteLine($"Length of line using two points ({x1},{x1}) and ({y2},{y2}) is : {Lengthline2}");

            Console.Write("\n\nFirst Line is Equal To Second Line : ");
            Console.WriteLine((Lengthline1).Equals(Lengthline2));
        }
    }
}
