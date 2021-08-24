using System;

namespace LEAP_Console_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            var input1 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter number: ");
            var input2 = Convert.ToDecimal(Console.ReadLine());
            //TODO input validation

            Console.Write("Enter operator ( X / + - )  :");
            string operator1 = Console.ReadLine();
            // TODO input validation
            
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

            Console.WriteLine($" {input1} {operator1} {input2} = {result}");
            
        }
    }
}
