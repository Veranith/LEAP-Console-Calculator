using System;
using System.Collections.Generic;

namespace LEAP_Console_Calculator
{
    class Utilities
    {
        /// <summary>
        /// This funciton prompts validated decimal varable from user with custom message
        /// </summary>
        /// <param name="message"> This is the message used in the prompt to the user </param>
        /// <returns> Returns a decimal variable </returns>
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

        /// <summary>
        /// This funciton prompts validated operation from user with custom message
        /// </summary>
        /// <param name="message"> This is the message used in the prompt to the user </param>
        /// <returns> Returns a string with the operation type </returns>
        public string getOperator(string message)
        {
            string userInput;
            var allowedOperators = new List<string> { "x", "*", "/", "\\", "+", "-" };

            do
            {
                userInput = getInput(message);
            } while (!allowedOperators.Contains(userInput.ToLower()));

            return userInput;
        }

        /// <summary>
        /// Performs the basic math given the inputs an math operator 
        /// </summary>
        /// <param name="input1"> This is the first number in the calculation </param>
        /// <param name="input2"> This is the second number in the calculation </param>
        /// <param name="operator1"> This is the operator for which math function will be performed ( *, /, +, - ) </param>
        /// <returns> Returns a decimal with the result of the calculation </returns>
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

            return result;
        }

        /// <summary>
        /// This is a local method a message to the user and prompt the user for input.
        /// </summary>
        /// <param name="message"> This is the message that is displayed to the user. </param>
        /// <returns> Returns a string with the users input. </returns>
        public string getInput(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
    }
}
