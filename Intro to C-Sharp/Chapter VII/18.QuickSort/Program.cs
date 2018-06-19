using System;
using System.Numerics;

class Tribonaci
{
    public static void Main()
    {
        BigInteger a = int.Parse(Console.ReadLine());
        BigInteger b = int.Parse(Console.ReadLine());
        BigInteger c = int.Parse(Console.ReadLine());
        BigInteger d = 0;
        int n = int.Parse(Console.ReadLine());

        if (n == 1)
        {
            Console.WriteLine(a);
        }
        else if (n == 2)
        {
            Console.WriteLine(b);
        }
        else if (n == 3)
        {
            Console.WriteLine(c);
        }
        else
        {
            for (int i = 0; i < n - 3; i++)
            {
                d = a + b + c;
                a = b;
                b = c;
                c = d;
            }
            Console.WriteLine(d);
        }


    }
}