using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Utility
    {
        //Validations
        public int StringToInteger(string theString)
        {
            int theInt;
            while (!int.TryParse(theString, out theInt))
            {
                Console.WriteLine("You did not enter a valid number");
                theString = Console.ReadLine();
            }
            return theInt;
        }

        public string StringValidation(string stringName)
        {
            int num;
            while (int.TryParse(stringName, out num) || string.IsNullOrEmpty(stringName))
            {
                Console.WriteLine("Please enter a valid word/sentence");
                stringName = Console.ReadLine();

            }
            return stringName;
        }

        public decimal DecimalValidation(string phrase)
        {
            decimal theDecimal;
            while (!decimal.TryParse(phrase, out theDecimal))
            {
                Console.WriteLine("Please enter a valid number");
                phrase = Console.ReadLine();
            }
            return theDecimal;
        }
    }
}
