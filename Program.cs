using System;

namespace LEAP_Console_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string continueLoop = "n";
            var calculator = new Utilities();

            do
            {
                try
                {
                    decimal input1 = calculator.getNumber("Enter number 1 (numbers only): ");
                    decimal input2 = calculator.getNumber("Enter number 2 (numbers only): ");

                    string operator1 = calculator.getOperator("Enter operator ( X / + - )  :");

                    decimal result = calculator.doCalculation(input1, input2, operator1);

                    Console.WriteLine($"\n\n\t{input1} {operator1} {input2} = {result}");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine($"Unable to divide by 0.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Result is too large for this calculator.");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Unknown error has occurred.");
                    Console.WriteLine(e.ToString());
                }

                continueLoop = calculator.getInput("\n\nWould you like to perform another calculation? (y/N) ");

            } while (continueLoop.ToLower() == "y" || continueLoop.ToLower() == "yes");
        }
    }
}
