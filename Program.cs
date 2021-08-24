using System;

namespace LEAP_Console_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var calculator = new utilities();
                
                decimal input1 = calculator.getNumber("Enter number 1 (numbers only): ");
                decimal input2 = calculator.getNumber("Enter number 2 (numbers only): ");

                string operator1 = calculator.getOperator("Enter operator ( X / + - )  :");

                decimal result = calculator.doCalculation(input1, input2, operator1);
                
                Console.WriteLine($" {input1} {operator1} {input2} = {result}");

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine($"Unable to divide by 0.");
            }
            // TODO add more exception handling

            // TODO add Y/N do while loop to start over


        }
    }
}
