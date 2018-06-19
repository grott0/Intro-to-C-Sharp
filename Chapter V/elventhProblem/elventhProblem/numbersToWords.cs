using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numbersToWords
{
    class numbersToWords
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int ones = n % 10;
            int tenths = (n / 10) % 10;
            int hundreths = (n / 100) % 10;
            int exception = n / 10;

            if (n >= 0 && n <= 19)
            {
                switch (n)
                {
                    case 0: Console.WriteLine("Zero."); break;
                    case 1: Console.WriteLine("One."); break;
                    case 2: Console.WriteLine("Two."); break;
                    case 3: Console.WriteLine("Three."); break;
                    case 4: Console.WriteLine("Four."); break;
                    case 5: Console.WriteLine("Five."); break;
                    case 6: Console.WriteLine("Six."); break;
                    case 7: Console.WriteLine("Seven."); break;
                    case 8: Console.WriteLine("Eight."); break;
                    case 9: Console.WriteLine("Nine."); break;
                    case 10: Console.WriteLine("Ten."); break;
                    case 11: Console.WriteLine("Eleven."); break;
                    case 12: Console.WriteLine("Twelve."); break;
                    case 13: Console.WriteLine("Thirteen."); break;
                    case 14: Console.WriteLine("Fourteen."); break;
                    case 15: Console.WriteLine("Fifteen."); break;
                    case 16: Console.WriteLine("Sixteen."); break;
                    case 17: Console.WriteLine("Seventeen."); break;
                    case 18: Console.WriteLine("Eighteen."); break;
                    case 19: Console.WriteLine("Nineteen."); break;


                }
            }
            else if (n == 100)
            {
                Console.WriteLine("One hundred.");
            }
            else if (n >= 20 && n <= 100 && ones == 0)
            {
                switch (tenths)
                {
                    case 2: Console.WriteLine("Twenty."); break;
                    case 3: Console.WriteLine("Thirty."); break;
                    case 4: Console.WriteLine("Fourty."); break;
                    case 5: Console.WriteLine("Fifty."); break;
                    case 6: Console.WriteLine("Sixty."); break;
                    case 7: Console.WriteLine("Seventy."); break;
                    case 8: Console.WriteLine("Eighty."); break;
                    case 9: Console.WriteLine("Ninety."); break;
                }
            }
            else if (n >= 20 && n <= 100)
            {
                switch (tenths)
                {
                    case 2: Console.Write("Twenty "); break;
                    case 3: Console.Write("Thirty "); break;
                    case 4: Console.Write("Fourty "); break;
                    case 5: Console.Write("Fifty"); break;
                    case 6: Console.Write("Sixty "); break;
                    case 7: Console.Write("Seventy "); break;
                    case 8: Console.Write("Eighty "); break;
                    case 9: Console.Write("Ninety "); break;
                }
                switch (ones)
                {
                    case 1: Console.WriteLine("one."); break;
                    case 2: Console.WriteLine("two."); break;
                    case 3: Console.WriteLine("three."); break;
                    case 4: Console.WriteLine("four."); break;
                    case 5: Console.WriteLine("five."); break;
                    case 6: Console.WriteLine("six."); break;
                    case 7: Console.WriteLine("seven."); break;
                    case 8: Console.WriteLine("eight."); break;
                    case 9: Console.WriteLine("nine."); break;
                }
            }
            else if (ones == 0)
            {
                switch (hundreths)
                {
                    case 1: Console.Write("One hundred and "); break;
                    case 2: Console.Write("Two hundred and "); break;
                    case 3: Console.Write("Three hundred and "); break;
                    case 4: Console.Write("Four hundred and "); break;
                    case 5: Console.Write("Five hundred and "); break;
                    case 6: Console.Write("Six hundred and "); break;
                    case 7: Console.Write("Seven hundred and "); break;
                    case 8: Console.Write("Eight hundred and "); break;
                    case 9: Console.Write("Nine hundred and "); break;

                }
                switch (tenths)
                {

                    case 1: Console.WriteLine("ten."); break;
                    case 2: Console.WriteLine("twenty."); break;
                    case 3: Console.WriteLine("thirty."); break;
                    case 4: Console.WriteLine("fourty."); break;
                    case 5: Console.WriteLine("fifty."); break;
                    case 6: Console.WriteLine("sixty."); break;
                    case 7: Console.WriteLine("seventy."); break;
                    case 8: Console.WriteLine("eighty."); break;
                    case 9: Console.Write("ninety."); break;

                }
            }
            else if (n > 100)
            {
                if (tenths == 0)
                {
                    switch (hundreths)
                    {
                        case 1: Console.Write("One hundred and "); break;
                        case 2: Console.Write("Two hundred and "); break;
                        case 3: Console.Write("Three hundred and "); break;
                        case 4: Console.Write("Four hundred and "); break;
                        case 5: Console.Write("Five hundred and "); break;
                        case 6: Console.Write("Six hundred and "); break;
                        case 7: Console.Write("Seven hundred and "); break;
                        case 8: Console.Write("Eight hundred and "); break;
                        case 9: Console.Write("Nine hundred and "); break;
                    }
                    switch (ones)
                    {
                        case 1: Console.WriteLine("one."); break;
                        case 2: Console.WriteLine("two."); break;
                        case 3: Console.WriteLine("three."); break;
                        case 4: Console.WriteLine("four."); break;
                        case 5: Console.WriteLine("five."); break;
                        case 6: Console.WriteLine("six."); break;
                        case 7: Console.WriteLine("seven."); break;
                        case 8: Console.WriteLine("eight."); break;
                        case 9: Console.WriteLine("nine."); break;
                    }

                }
                else if (tenths == 1 && ones > 0)
                {
                    switch (hundreths)
                    {
                        case 1: Console.Write("One hundred and "); break;
                        case 2: Console.Write("Two hundred and  "); break;
                        case 3: Console.Write("Three hundred and "); break;
                        case 4: Console.Write("Four hundred and "); break;
                        case 5: Console.Write("Five hundred and "); break;
                        case 6: Console.Write("Six hundred and "); break;
                        case 7: Console.Write("Seven hundred and "); break;
                        case 8: Console.Write("Eight hundred and "); break;
                        case 9: Console.Write("Nine hundred and "); break;
                    }
                    switch (ones)
                    {

                        case 1: Console.WriteLine("eleven"); break;
                        case 2: Console.WriteLine("twelve "); break;
                        case 3: Console.WriteLine("thirteen"); break;
                        case 4: Console.WriteLine("fourteen"); break;
                        case 5: Console.WriteLine("fifteen"); break;
                        case 6: Console.WriteLine("sixteen"); break;
                        case 7: Console.WriteLine("seventeen "); break;
                        case 8: Console.WriteLine("eighteen "); break;
                        case 9: Console.WriteLine("nineteen "); break;
                    }
                }


                else
                {
                    switch (hundreths)
                    {
                        case 1: Console.Write("One hundred "); break;
                        case 2: Console.Write("Two hundred "); break;
                        case 3: Console.Write("Three hundred "); break;
                        case 4: Console.Write("Four hundred "); break;
                        case 5: Console.Write("Five hundred "); break;
                        case 6: Console.Write("Six hundred "); break;
                        case 7: Console.Write("Seven hundred "); break;
                        case 8: Console.Write("Eight hundred "); break;
                        case 9: Console.Write("Nine hundred "); break;
                    }
                    switch (tenths)
                    {
                        case 2: Console.Write("twenty "); break;
                        case 3: Console.Write("thirty "); break;
                        case 4: Console.Write("fourty "); break;
                        case 5: Console.Write("fifty "); break;
                        case 6: Console.Write("sixty "); break;
                        case 7: Console.Write("seventy "); break;
                        case 8: Console.Write("eighty "); break;
                        case 9: Console.Write("ninety "); break;
                    }
                    switch (ones)
                    {
                        case 1: Console.WriteLine("one."); break;
                        case 2: Console.WriteLine("two."); break;
                        case 3: Console.WriteLine("three."); break;
                        case 4: Console.WriteLine("four."); break;
                        case 5: Console.WriteLine("five."); break;
                        case 6: Console.WriteLine("six."); break;
                        case 7: Console.WriteLine("seven."); break;
                        case 8: Console.WriteLine("eight."); break;
                        case 9: Console.WriteLine("nine."); break;
                    }

                }

            }


        }
    }
}
