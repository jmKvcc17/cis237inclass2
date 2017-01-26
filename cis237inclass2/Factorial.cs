using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass2
{
    class Factorial
    {
        public ulong CalculateFactorial(ulong number)
        {
            
            // this is the base case,
            // if the number is one, just return it
            if (number == 1)
                return 1;

            // Not the base case, so make a recursive call
            // to ourself
           return number *  CalculateFactorial(number - 1);
        }

    }
}
