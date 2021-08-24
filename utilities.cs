using System;

namespace LEAP_Console_Calculator
{
    class utilities
    {
        public decimal getNumber(string message)
        {

            string userInput;
            decimal result;
            do
            {
                userInput = getInput(message);
            } 
            while (!Decimal.TryParse(userInput, out result));
            
            return result;

        }

        private string getInput(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
    }
}
