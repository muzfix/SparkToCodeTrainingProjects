using System.Diagnostics.Contracts;

namespace Functions
{
    internal class Program
    {
        // user defined functions parts
        // method head (name, return type, parameters)
        // method body
        /*

        [access_modifier] [return_type] [function_name]([parameters])
        {
            // Function body
        }

        - access_modifier: Defines the accessibility of the function! public, private, protected, internal
        - return_type: specifies the type of value the function returns. If the function does not return any value, use void.
        - void doesnt return anything e.g. clear message 
        - function_name: The name of the function, which should be descriptive and follow naming conventions.
        note: any programming block should implement a single task or a closely related set of tasks.
        note: If a function is doing too many things, it should be broken down into smaller functions.
        (single responsibility principle) 
        - pramaterers : A comma seperated list of input values that the function can accept.
        Each parameter has a type and a name, and they are used to pass data into the function.

        Function signature should be unique within the scope.
        Any 2 functions should be differengt in name, return type, parameters (types, number, order).

        function body: The block of code that defines what the function does. 
        It is enclosed in curly braces {} and contains the statements that are executed when the function is called.



         */
        //Example of a user defined function
        //function implementation

        public static void PrintMainMenu() // no return, no parameters 
        {
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Exit");
        }


        public static void PrintWelcomeMessage(string name) // no return, with parameters
        {
            Console.WriteLine("Welcome to the application, " + name + ".");
        }

        public static DateTime GetTodaysDate() // return type is DateTime, no parameters 
        {
            return DateTime.Today;
        }

        public static int AddNumbers(int num1, int num2) // return type is int, with parameters
        {
            return num1 + num2;
        }

        //Function overloading : same function name with different signatures
        //( return type, parameters types, number, order)

        public static void WriteLine()
        {

        }

        public static void WriteLine(int input)
        {
            Console.WriteLine(input);
        }

        public static void WriteLine(string input)
        {
            Console.WriteLine(input);
        }

        //Main Method
        static void Main(string[] args)
        {
            //function call

            PrintWelcomeMessage("Ahmed");
            

            PrintMainMenu();

            Console.WriteLine();
            Console.WriteLine(1);
            Console.WriteLine("Karim");
            Console.WriteLine(DateTime.Now);

            
            Console.WriteLine("Hello, World!");
        }
    }
}
