namespace SparkToCode_program1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // program to show welcome message 
            /*
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("hello " + userName);

            Console.Write("Enter your age: ");
            int userAge = int.Parse(Console.ReadLine());
            Console.WriteLine(userName + " your age is " + userAge);

            Console.WriteLine("hello " + userName + " welcome to Spark!");
            /////////////////////////
            ///
            */
            //Console.WriteLine("enter first number: ");
            //float firstNumber = float.Parse(Console.ReadLine());

            //Console.WriteLine("enter second number: ");
            //float secondNumber = float.Parse(Console.ReadLine());

            //float additionResult = firstNumber + secondNumber;
            //float subtractionResult = firstNumber - secondNumber;
            //float multiplicationResult = firstNumber * secondNumber;
            //float divisionResult = firstNumber / secondNumber;
            //float remainderResult = firstNumber % secondNumber;
            //bool comparisonResult = firstNumber == secondNumber;

            //bool testResult = !(10 > 5); // false

            //// and: &&
            //// Or: ||
            //// not: !

            //Console.WriteLine("Addition result: " + additionResult);
            //Console.WriteLine("Subtraction result: " + subtractionResult);
            //Console.WriteLine("Multiplication result: " + multiplicationResult);
            //Console.WriteLine("Division result: " + divisionResult);
            //Console.WriteLine("Remainder result: " + remainderResult);
            //Console.WriteLine("Comparison result: " + comparisonResult);
            /////////////////////////////////////////////////////////////////////////////////////////////////////
            ///


            // program to test conditional statements
            //Console.WriteLine("Enter your degree: ");
            //float degree = float.Parse(Console.ReadLine());

            //if(degree < 50 && degree > -1)
            //{
            //    Console.WriteLine("You have failed. ");
            //}
            //else if(degree >= 50 && degree < 60 && degree > -1)
            //{
            //    Console.WriteLine("You have passed with grade D. ");
            //}
            //else if(degree >= 60 && degree < 70 && degree > -1)
            //{
            //    Console.WriteLine("You have passed with grade C. ");
            //}
            //else if (degree >= 70 && degree < 80 && degree > -1)
            //{
            //    Console.WriteLine("You have passed with grade B. ");
            //}
            //else if (degree >= 80 && degree > -1)
            //{
            //    Console.WriteLine("You have passed with grade A. ");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid number entered. ");
            //}

            ///////////////////////////////////////////////////////////////////////

            Console.WriteLine("welcome to main menu: ");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Check Balance");

            Console.WriteLine("Please choose an option: ");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("deposit.");
                    break;

                case 2:
                    Console.WriteLine("withdraw.");
                    break;

                case 3:
                    Console.WriteLine("check balance.");
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    break;  
            }

            // uploaded
            /*
             * Spark to code
             * session one explanation
            */

        }
    }
}
