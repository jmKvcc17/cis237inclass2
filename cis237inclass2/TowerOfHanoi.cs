using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass2
{
    class TowerOfHanoi
    {
        public TowerOfHanoi()
        {
            Console.WriteLine("Enter the number of disks to use.");
            Console.WriteLine("Less than 5 is good.");

            string input = Console.ReadLine();
            int diskNumber = Int32.Parse(input);

            moveDisc(diskNumber, 'A', 'B', 'C');
        }

        private void moveDisc(int n, char src, char aux, char dest)
        {
            // If this is true, we have hit the base case.
            // All printing is done in the base case.
            if (n == 1)
            {
                Console.WriteLine("Move disc from tower {0} to tower {1}", src, dest);
            }
            else
            {
                // Make a recursive call to move n-1 discs from the source peg, to
                // the aux peg
                moveDisc(n - 1, src, dest, aux);

                // Make a recursive call to move the 1 (bottom) disc fr omteh src
                // to the destination
                moveDisc(1, src, aux, dest);

                // Make a recursive call to move n-1 discs fr omteh aux to the dest
                moveDisc(n - 1, aux, src, dest);
            }
        }
    }
}
