using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1.Zadanie7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину ребра куба = ");
            int a = Convert.ToInt32(Console.ReadLine());
            double V, S;
            GetParam(a, out V, out S);
            Console.WriteLine("Площадь поверхности куба = {0}", S);
            Console.WriteLine("Объем куба = {0}", V);
            Console.ReadKey();
        }
        static void GetParam(int a, out double S, out double V)
        {
            S = 6 * (a * a);
            V = a * a * a;
        }

    }
}
