using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.UTFString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            string input = Console.ReadLine();
            byte[] bytes = Encoding.Unicode.GetBytes(input);
            string output = Encoding.Unicode.GetString(bytes);

            for (int i = 0; i < output.Length; i++)
            {
                Console.Write("\\u{0:x4}", (int)output[i]);
            }
        }
    }
}
