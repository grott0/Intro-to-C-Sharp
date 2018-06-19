using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace _20.ExtractDates
{
    class Program
    {
        static void Main()
        {


            string input = Console.ReadLine();
            string pattern = @"(\d{2})\.(\d{2})\.(\d{4})";
            string dateFormat = "dd.MM.yyyy";
            CultureInfo cultureProvider = new CultureInfo("en-CA");
            MatchCollection matches = Regex.Matches(input, pattern);
            PrintAllDates(matches, dateFormat, cultureProvider);



        }
        static void PrintAllDates(MatchCollection matches, string dateFormat,
            CultureInfo cultureProvider, string pattern)
        {

            foreach (Match match in matches)
            {
                string validateFirstGroup = Regex
                    .Match(match.ToString(), pattern)
                    .Groups[1]
                    .ToString();
                string validateSecondGroup = Regex
                    .Match(match.ToString(), pattern)
                    .Groups[2]
                    .ToString();
                validateFirstGroup = 
                    validateFirstGroup.Length == 2 ? validateFirstGroup : validateFirstGroup.Insert(0, "0");

                DateTime date = DateTime.ParseExact(match.ToString(), dateFormat, cultureProvider);
                Console.WriteLine(date.ToString());
            }
        }
        static void PrintAllCultures()
        {
            CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.AllCultures);
            foreach (CultureInfo culture in cultures)
            {
                Console.WriteLine(culture);
            }
        }
        

    }
}
