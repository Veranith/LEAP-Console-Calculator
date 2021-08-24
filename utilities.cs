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

        public string getOperator(string message)
        {
            string userInput;

            // TODO was unable to quickly find out to compare a string to a array of chars or something similar. Will come back to this if I have time. 
            //char[] allowedOperators = { 'x', '*', '/', '\\', '+', '-' };
            do
            {
                userInput = getInput(message);
            } while (!(userInput.ToLower() == "x" || userInput == "*" || userInput == "/" || userInput == "\\" || userInput == "+" || userInput == "-" ));

            return userInput;
        }

        private string getInput(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
    }
}
