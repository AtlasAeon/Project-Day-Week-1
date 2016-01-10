using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formatProjectDay1Challenge1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ask for user input of a company's information and manager information
            Console.Write("Enter company Name: ");
            string companyName = Console.ReadLine();

            Console.Write("Enter company address: ");
            string companyAddress = Console.ReadLine();

            Console.Write("Enter company phone number: ");
            string companyPhoneNumber = Console.ReadLine();

            Console.Write("Enter company fax number: ");
            string companyFaxNumber = Console.ReadLine();

            Console.Write("Enter company website: ");
            string companyWebsite = Console.ReadLine();

            Console.Write("Enter manager first name: ");
            string managerFirstName = Console.ReadLine();

            Console.Write("Enter manager last name: ");
            string managerLastName = Console.ReadLine();

            Console.Write("Enter manager phone number: ");
            string managerPhoneNumber = Console.ReadLine();

            string managerFullName = managerFirstName + " " + managerLastName;

            //Prints user input out to console
            Console.WriteLine(
                "\n{0, -30}{1, -20}{2}\n{3, -30}{5, -20}{6}\n{4, -50}{7}\n\n{8, -20}{9, 20}\n{10, -20}{11, 20}",
                "Company Name and Address", "Company Website", "Company Phone and Fax",
                companyName, companyAddress, companyWebsite, companyPhoneNumber, companyFaxNumber,
                "Manager Full Name", "Manager Phone Number",
                managerFullName, managerPhoneNumber
            );

            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();
        }
    }
}