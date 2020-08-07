using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A048_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("calculate n!");
            Console.WriteLine("Please input n");
            int n = int.Parse(Console.ReadLine());

            int fact = 1;

            for (int i = 2; i <= n; i++)
                fact *= i;

            Console.WriteLine("{0}! = {1}", n, fact);
        }
    }
}
