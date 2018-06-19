using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thirdProblem
{
    class companyInfo
    {
        static void Main()
        {
            Console.Write("Enter the name of the company: ");
            string companyName = Console.ReadLine();
            Console.Write("Enter the adress of the company: ");
            string companyAdress = Console.ReadLine();
            Console.Write("Enter the fax number of the company: ");
            string faxNumber = Console.ReadLine();
            Console.Write("Enter the phone number of the company: ");
            string phoneNumber = Console.ReadLine();
            Console.Write("Enter the website of the company: ");
            string webSite = Console.ReadLine();
            Console.Write("Enter the first name of the manager: ");
            string managerFirstName = Console.ReadLine();
            Console.Write("Enter the last name of the manager: ");
            string managerLastName = Console.ReadLine();
            Console.Write("Enter the manager's phone number: ");
            string managerPhoneNumber = Console.ReadLine();


            Console.WriteLine();
            Console.WriteLine("{0,50}", "Company info: ");
            Console.WriteLine(" The company name is: {0} \n The company adress is: {1} \n The company fax number is: {2} \n The company phone number is: {3} \n The company website is: {4}",companyName,companyAdress,faxNumber,phoneNumber,webSite);
            Console.WriteLine();
            Console.WriteLine("{0,50}", "Manager info: ");
            Console.WriteLine(" Manager name: {0} {1} \n Manager phone number: {2}", managerFirstName, managerLastName, managerPhoneNumber);
            
        }
    }
}
