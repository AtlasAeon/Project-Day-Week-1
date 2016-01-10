using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace companyManagerInfoProject {
    class Program {
        static void Main(string[] args) {

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

            Console.Write("Enter manager last name:");
            string managerLastName = Console.ReadLine();

            Console.Write("Enter manager phone number :");
            string managerPhoneNumber = Console.ReadLine();

            //Prints user input out to console
            Console.WriteLine(
                "Company Name: "            + companyName + "\n" +
                "Company Address: "         + companyAddress + "\n" +
                "Company Phone Number: "    + companyPhoneNumber + "\n" +
                "Company Fax Number: "      + companyFaxNumber + "\n" +
                "Company Website: "         + companyWebsite + "\n" +
                "Manager First Name and Last Name: " 
                                            + managerFirstName + " " 
                                            + managerLastName + "\n" +
                "Manager Phone Number: "    + managerPhoneNumber
            );
            
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();
        }
    }
}
