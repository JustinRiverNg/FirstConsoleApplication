using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            /** Variable Declarations. */
            int num1, num2;
            int result = 0;

            /** Prompt the user for 2 numbers. */
            Console.Write("Enter your first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            /** Prompt the user for operation choice. */
            Console.WriteLine("Your choices are:\n1.Add 2.Subtract 3.Multiply");
            Console.Write("Enter your operation choice: ");
            int operationChoice = Convert.ToInt32(Console.ReadLine());

            /** Determine the operation choice. */
            if (operationChoice == 1)
            {
                result = num1 + num2;
            }
            else if (operationChoice == 2)
            {
                result = num1 - num2;
            }
            else if (operationChoice == 3)
            {
                result = num1 * num2;
            }
            Console.WriteLine(result);
            Console.WriteLine("Press enter to close the console.");
            Console.ReadLine();
        }
    }
}
