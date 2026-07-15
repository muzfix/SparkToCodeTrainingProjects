using System.Numerics;

namespace Task4
{
    internal class Program
    {
        //Task 1 Print Welcome Message
        //static void PrintWelcome(string userName)
        //{
        //    Console.WriteLine("Welcome, " + userName + " to the app!");
        //}


        //Task 2 Square Number Function
        static int Square(int userNumSq)
        {
            userNumSq = userNumSq * userNumSq;
            return userNumSq;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter your name: ");
            //string userName = Console.ReadLine();

            //Program.PrintWelcome(userName);

            Console.WriteLine("Enter a number to be squared: ");
            int userNumSq = int.Parse(Console.ReadLine());
            Console.WriteLine("The squared number is: " + Square(userNumSq));

        }
    }
}
