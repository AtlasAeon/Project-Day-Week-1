using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circleAreaAndPerimeter {
    class Program {
        static void Main(string[] args) {

            Console.Write("Enter the radius of their circle: ");
            string userRadius = Console.ReadLine();

            int r = int.Parse(userRadius); //Converts user radius to an int data type

            double circleArea = Math.PI * r * r; //Formula for the area of a circle
            double circlePerimeter = 2 * Math.PI * r; // Formula for the perimeter of a circle

            Console.WriteLine("The perimeter of your circle is {0}.", circlePerimeter);
            Console.WriteLine("The area of your circle is {0}.", circleArea);

            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();

        }
    }
}
