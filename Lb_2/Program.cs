using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double z1 = (Math.Pow(x, 2) + 2 * x - 3 + (x + 1) * Math.Sqrt(Math.Pow(x, 2) - 9)) / 
                (Math.Pow(x, 2) - 2 * x - 3 + (x - 1) * Math.Sqrt(Math.Pow(x, 2) - 9));
            Console.WriteLine($"z1 = {z1}");
            double z2 = Math.Sqrt((x + 3) / (x - 3));
            Console.WriteLine($"z2 = {z2}");
            Console.ReadKey();
        }
    }
}
