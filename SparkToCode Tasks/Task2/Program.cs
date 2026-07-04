namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Csharp fundamentals part 2
            // Task 1: Countdown Timer
            //Console.WriteLine("Enter a number for the countdown: ");
            //int countTimer = int.Parse(Console.ReadLine());
            //for (int i = countTimer; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //    if (i == 1)
            //    {
            //        Console.WriteLine("Liftoff!");
            //    }
            //}

            //Task 2: Sum of numbers 1 to N
            //Console.WriteLine("Enter a positive whole number to calculate the sum from 1 to N: ");
            //int userNum = int.Parse(Console.ReadLine());
            //int userSum = 0;

            //for (int i = userNum; i > 0; i--)
            //{
            //    userSum += i;
            //}

            //Console.WriteLine("Sum of numbers from 1 to " + userNum + " is: " + userSum);

            //Task 3: Multiplication Table

            Console.WriteLine("Enter a number to display its multiplication table: ");
            int userNum2 = int.Parse(Console.ReadLine());

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i*userNum2);
            }





        }
    }
}
