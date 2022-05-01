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

            double X1;
            double Y1;
            double X2;
            double Y2;
            double Length;


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

            Length = Math.Sqrt((Xpower + Ypower));

            Console.WriteLine($"Length of line using two points ({X1},{X1}) and ({Y2},{Y2}) is : {Length}");

        }
    }
}
