using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _340Easy_FirstRecurringCharacter
{
    class FirstRecurringCharacter
    {
        public static void Go() {


            Console.WriteLine("Please enter a string of alphabetical characters.");
            var enteredString = Console.ReadLine();

            First(enteredString);
        }

        public static void First(string enteredString) {

            var zero = enteredString.First();
            Console.WriteLine("The first letter of what you entered is " + zero);

        }
    }
}
