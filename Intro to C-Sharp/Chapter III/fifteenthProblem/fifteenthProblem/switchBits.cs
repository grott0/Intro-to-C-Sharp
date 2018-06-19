using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fifteenthProblem
{
    class switchBits
    {
        static void Main()
        {
            //Input desired number and declare variables

            int n = int.Parse(Console.ReadLine());
            int mask = 1;

            //Create masks for the desired bits

            int bitThree = mask << 3;
            int bitFour = mask << 4;
            int bitFive = mask << 5;
            int bitTwentyFour = mask << 24;
            int bitTwentyFive = mask << 25;
            int bitTwentySix = mask << 26;

            //Check the value of the desired bits

            int check3 = bitThree & n;
            int check4 = bitFour & n;
            int check5 = bitFive & n;
            int check24 = bitTwentyFour & n;
            int check25 = bitTwentyFive & n;
            int check26 = bitTwentySix & n;

            //If values of bits 3,4,5 and 24,25,26 are different, switch accordingly

            //Bits 3 and 24
            if (check3 != 0 && check24 != 0 || check3 == 0 && check24 == 0)
            {
                Console.WriteLine("Bits 3 and 24 are equal.");
            }
            else if (check3 != 0 && check24 == 0)
            {
                n = bitTwentyFour | n;
                n = ~bitThree & n;
            }
            else if (check3 == 0 && check24 != 0)
            {
                n = bitThree | n;
                n = ~bitTwentyFour & n;
            }

            //Bits 4 and 25
            if (check4 != 0 && check25 != 0 || check4 == 0 && check25 == 0)
            {
                Console.WriteLine("Bits 4 and 25 are equal.");
            }
            else if (check4 != 0 && check25 == 0)
            {
                n = bitTwentyFive | n;
                n = ~bitFour & n;
            }
            else if (check4 == 0 && check25 != 0)
            {
                n = bitFour | n;
                n = ~bitTwentyFive & n;
            }

            //Bits 5 and 26
            if (check5 != 0 && check26 != 0 || check5 == 0 && check26 == 0)
            {
                Console.WriteLine("Bits 5 and 26 are equal.");
            }
            else if (check5 != 0 && check26 == 0)
            {
                n = bitTwentySix | n;
                n = ~bitFive & n;
            }
            else if (check5 == 0 && check26 != 0)
            {
                n = ~bitTwentySix & n;
                n = bitFive | n;
            }

            //Print the result

            Console.WriteLine(n);
            
        }
    }
}
