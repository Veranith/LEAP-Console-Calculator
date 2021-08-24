using System;

namespace LEAP_Console_Calculator
{
    class utilities
    {
        // Get validated decimal varable from user
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

        // Gets and validates math operator from user
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

        // Performs the basic math given the inputs an
        public decimal doCalculation(decimal input1, decimal input2, string operator1)
        {
            decimal result = 0;
            switch (operator1.ToLower())
            {
                case "x":
                case "*":
                    result = input1 * input2;
                    break;
                case "/":
                case "\\":
                    result = input1 / input2;
                    break;
                case "+":
                    result = input1 + input2;
                    break;
                case "-":
                    result = input1 - input2;
                    break;
            }

            // TODO handle if result is too large

            return result;
        }
        private string getInput(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
    }
}
