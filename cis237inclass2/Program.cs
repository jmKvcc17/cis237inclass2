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
            TowerOfHanoi hanoi;

            Factorial calcFactorial = new Factorial();
            Console.WriteLine("Enter 1 for factorial or 2 for Tower of Hanoi");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Console.WriteLine("Solve 60!");
                Console.WriteLine("Answer: ");
                Console.WriteLine(calcFactorial.CalculateFactorial(60).ToString());
                Console.WriteLine();
            }
            else
            {
                // Do tower of hanoi
                hanoi = new TowerOfHanoi();
            }

            Console.ReadLine();
        }
    }
}
