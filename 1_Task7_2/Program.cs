using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Task7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            CalcCub(a);
            Console.ReadKey();
        }
        static void CalcCub(int a)
        {
            int S = 6 * a * a;
            int V = a * a * a;
            Console.WriteLine("Площадь поверхности куба равна {0}, объём куба равен {1}", S, V);
            
        }
    }
}
    

