using System;

namespace MethodsFM
{
    class Program
    {
        static void MyMethods()
        {
            /// Ask user for first value and convert to integer
            Console.WriteLine("Enter first integer");
            string userFirst;
            userFirst = Console.ReadLine();
            int first;
            first = Convert.ToInt32(userFirst);


            /// Ask user for second value and convert to integer
            Console.WriteLine("Enter second integer");
            string userSecond;
            userSecond = Console.ReadLine();
            int second;
            second = Convert.ToInt32(userSecond);

            /// Ask user for operation
            Console.WriteLine("Which operation would you like?");
            Console.WriteLine("Enter 1 for addition");
            Console.WriteLine("Enter 2 for subtraction");
            Console.WriteLine("Enter 3 for multiplication");
            Console.WriteLine("Enter 4 for division");
            string userMethod;
            userMethod = Console.ReadLine();
            int method;
            method = Convert.ToInt32(userMethod);

            ///Solve for addition
            if (method == 1)
            {
                int add;
                add = first + second;
                Console.WriteLine("The sum of " + first + " and " + second + " is "+add);
            }
            
            ///Solve for subtraction
            else if (method == 2)
            {
                int subtract;
                subtract = first - second;
                Console.WriteLine("The difference of " + first + " and " + second + " is "+subtract);
            }

            ///Solve for multiplication
            else if (method == 3)
            {
                int multiply;
                multiply = first * second;
                Console.WriteLine("The product of " + first + " and " + second + " is "+multiply);
            }

            ///Solve for division or return error if dividing by zero
            else if (method == 4 && second == 0)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            else if (method == 4)
            {
                int divide;
                divide = first / second;
                Console.WriteLine("The quotient of " + first + " and " + second + " is "+divide);
            }

            ///Invalid entry
            else
            {
                Console.WriteLine("Invalid selection");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Frank Mells");
            MyMethods();
        }
    }
}
