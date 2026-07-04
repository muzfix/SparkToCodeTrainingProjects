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

            //Console.WriteLine("Enter a number to display its multiplication table: ");
            //int userNum2 = int.Parse(Console.ReadLine());

            //for (int i = 1; i < 11; i++)
            //{
            //    Console.WriteLine( userNum2 + " * " + i + " = " + (i*userNum2));
            //}

            //Task 4: Password Retry

            //Console.WriteLine("Enter the password: ");
            //string userPass = Console.ReadLine();

            //while (userPass != "Spark2026")
            //{
            //    Console.WriteLine("Incorrect password. Try again: ");
            //    userPass = Console.ReadLine();
            //}

            //Console.WriteLine("Access Granted");

            //Task 5: Number Guessing Game

            
            int secretNum = 42;
            int userAttempts = 0;
            int userGuess;

            do 
            {
                Console.WriteLine("Try to guess the number: ");
                userGuess = int.Parse(Console.ReadLine());
                if (userGuess > secretNum)
                {
                    Console.WriteLine("Too high!");
                    userAttempts++;
                    
                    
                }
                else if (userGuess < secretNum)
                {
                    Console.WriteLine("Too low!");
                    userAttempts++;
                    
                }
                else
                {
                    Console.WriteLine("Congratulations! You guessed the number. It took you " + userAttempts + "attempts.");
                }

            }
            while (userGuess != secretNum);


        }
    }
}
