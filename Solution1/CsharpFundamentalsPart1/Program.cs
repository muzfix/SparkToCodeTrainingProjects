namespace CsharpFundamentalsPart1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // Task 1:
            // Create a console application that prompts the user for their name, age, height, and whether they are a student.
            // Then display the collected information back to the user.

            Console.WriteLine("Enter your name: ");
            string userName = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            int userAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your height in meters: ");
            double userHeight = double.Parse(Console.ReadLine());

            Console.WriteLine("Are you a student? (y/n): ");
            string userInput = Console.ReadLine();
            bool isStudent = false;
            if(userInput == "y")
            {
                Console.WriteLine("You are a student.");
            }
            else
            {
                Console.WriteLine("You are not a student.");
            }


        }
    }
}
