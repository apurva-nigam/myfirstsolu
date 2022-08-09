using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class Functions
    {
        static void Main()
        {
            Console.WriteLine("Enter Length and breadth");
            double len = Double.Parse(Console.ReadLine());
            double bre = Double.Parse(Console.ReadLine());
            double area = Rectangle(len, bre);
        }
        static double Rectangle(double length,double breadth)
        {
            length++;
            breadth++;
            double area = length * breadth;
            return area;
        }
       /*
        //In Parameters where the values are passed as arugments and the the result changes with an increment in value
         static void Main()
        {
            Console.WriteLine("Enter Length and Breadth");
            double len = Double.Parse(Console.ReadLine());
            double bre = Double.Parse(Console.ReadLine());
            double area = Rectangle(ref len, ref bre);
            Console.WriteLine("Area of Rectangle is {0}", area);
            Console.WriteLine("Length is {0}, Breadth is {1}",len,bre);
        }
        static double Rectangle(ref double length,ref double breadth)
        {
            length++;
            breadth++;
            double area = length * breadth;
            return area;
        }*/
       /* Ref parameters where the result of perimeter is shown in the output with reference to the agrument out double perimeter
        * static void Main()
        {
            Console.WriteLine("Enter the length and breadth");
            double len = Double.Parse(Console.ReadLine());
            double bre = Double.Parse(Console.ReadLine());
            double peri;
            double area = Rectangle(len, bre, out peri);
            Console.WriteLine("Area of Rectangle is {0}",area);
            Console.WriteLine("Perimeter Of Rectangle is {0}", peri);
        }
        static double Rectangle(double length, double breadth,out double perimeter)
        {
            double area = length * breadth;
            perimeter = 2 * (length + breadth);
            return area; 
        } 
       */
    }
}
