using System.Diagnostics.Metrics;

namespace CsharpFundamentalsPart1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // Task 1:
            // Create a console application that prompts the user for their name, age, height, and whether they are a student.
            // Then display the collected information back to the user.

            //Console.WriteLine("Enter your name: ");
            //string userName = Console.ReadLine();

            //Console.WriteLine("Enter your age: ");
            //int userAge = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter your height in meters: ");
            //double userHeight = double.Parse(Console.ReadLine());

            //Console.WriteLine("Are you a student? (y/n): ");
            //string userInput = Console.ReadLine();
            //bool isStudent = false;
            //if(userInput == "y")
            //{
            //    Console.WriteLine("You are a student.");
            //}
            //else
            //{
            //    Console.WriteLine("You are not a student.");
            //}

            // Task 2: 
            // Rectangle Calculator
            // 

            //Console.WriteLine("Enter the length of the rectangle: ");
            //float rLength = float.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the width of the rectangle: ");
            //float rWidth = float.Parse(Console.ReadLine());

            //Console.WriteLine("The area of the rectangle is: " + (rLength * rWidth));
            //Console.WriteLine("The perimeter of the rectangle is: " + (2 * (rLength + rWidth)));

            // Task 3:
            // Even or Odd Checker

            //Console.WriteLine("Enter a number to check if it is odd or even: ");
            //float userNum = float.Parse(Console.ReadLine());

            //if (userNum % 2 == 0)
            //{
            //    Console.WriteLine("The number is even.");
            //}
            //else
            //{
            //    Console.WriteLine("The number is odd.");
            //}

            // Task 4: voting eligibility checker

            Console.WriteLine("Enter your age to see if you are eligible to vote: ");
            int userAge2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Do you have a valid national ID? (y/n)");
            bool userInput2 = Console.ReadLine() == "y";

            if (userAge2 >= 18 && userInput2 == true)
            {
                Console.WriteLine("You are eligible to vote");
            }
            else
            {
                Console.WriteLine("You are not eligible to vote");
            }




        }
    }
}
