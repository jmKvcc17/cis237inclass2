using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass2
{
    class Program
    {
        static void Main(string[] args)
        {
            Factorial calcFactorial = new Factorial();

            Console.WriteLine("Solve 5!");
            Console.WriteLine("Answer: ");
            Console.WriteLine(calcFactorial.CalculateFactorial(60).ToString());
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
