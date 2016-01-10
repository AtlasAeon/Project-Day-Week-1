using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fiveIntegerAddUpProject{

    class Program {

        static void Main(string[] args) {

            int digitAddUp = 0;

            for (int i = 0; i < 5; i++) {
                Console.Write("Enter a number: ");
                string userDigits = Console.ReadLine();
                //int tempStorage = int.Parse(userDigits); //temporary storage for parsed digits
                digitAddUp += int.Parse(userDigits); //Don't have to store the value however
            }

            Console.WriteLine("Your 5 digit sum is " + digitAddUp);

            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();

        }

    }

}
