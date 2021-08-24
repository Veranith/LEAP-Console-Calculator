using System;

namespace LEAP_Console_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var inputs = new utilities();
                
                decimal input1 = inputs.getNumber("Enter number 1 (numbers only): ");
                decimal input2 = inputs.getNumber("Enter number 2 (numbers only): ");
                
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
            catch (DivideByZeroException)
            {
                Console.WriteLine($"Unable to divide by 0.");
                //throw;
            }
            
        }
    }
}
