using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _13.URLValidation
{
    class Program
    {
        static void Main()
        {
            char[] delimiters = { ':', '/'};
            string input = Console.ReadLine();
            string pattern = @"([\w]+):([\/\w\.\-]+)\/([\w\/\$\?\=\.\-\^\&\#\%\!\(\)]+)";
            Regex rgx = new Regex(pattern);
            Match match = rgx.Match(input);


            if (match.ToString().Equals(string.Empty))
            {
                Console.Write("Invalid input!");
                return;
            }

            string[] args = match.ToString().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            bool protocolIsValid = ProtocolIsValid(args[0]);

            if (protocolIsValid)
            {
                Print(args);
            }
            else
            {
                Console.WriteLine("Invalid protocol!");
            }
        }

        static bool ProtocolIsValid(string protocol)
        {
            string[] validProtocols = { "http", "https", "ftp" };

            for (int i = 0; i < validProtocols.Length; i++)
            {
                if (validProtocols[i].Equals(protocol))
                {
                    return true;
                }
            }

            return false;
        }

        static void Print(string[] args)
        {
            string protocol = args[0];
            string server = args[1];
            Console.WriteLine("[protocol] = {0}\n[server] = \"{1}\"", protocol, server);

            if (args.Length > 1)
            {
                Console.Write("[resource] = ");
                for (int i = 2; i < args.Length; i++)
                {
                    Console.Write("/" + args[i]);
                }
                Console.WriteLine();
            }
            else
            {
                Console.Write("[resource] = no resource was specified");
            }

        }
    }
}
