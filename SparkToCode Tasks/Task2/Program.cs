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


            //int secretNum = 42;
            //int userAttempts = 0;
            //int userGuess;

            //do 
            //{
            //    Console.WriteLine("Try to guess the number: ");
            //    userGuess = int.Parse(Console.ReadLine());
            //    if (userGuess > secretNum)
            //    {
            //        Console.WriteLine("Too high!");
            //        userAttempts++;


            //    }
            //    else if (userGuess < secretNum)
            //    {
            //        Console.WriteLine("Too low!");
            //        userAttempts++;

            //    }
            //    else
            //    {
            //        Console.WriteLine("Congratulations! You guessed the number. It took you " + userAttempts + "attempts.");
            //    }

            //}
            //while (userGuess != secretNum);

            //Task 6: Safe Division Calculator

            //double userNum1 = 0;
            //double userNum2 = 0;
            //bool userInputValid = false;

            //do
            //{
            //    Console.WriteLine("Safe division calculator");
            //    try
            //    {
            //        Console.WriteLine("Enter the first number: ");
            //        userNum1 = double.Parse(Console.ReadLine());
            //        Console.WriteLine("Enter the second number: ");
            //        userNum2 = double.Parse(Console.ReadLine());
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine("Invalid input. Please enter a number.");
            //        continue;
            //    }

            //    if (userNum2 == 0)
            //    {
            //        Console.WriteLine("Cannot divide by zero. Please enter a non-zero number.");
            //        continue;
            //    }

            //    userInputValid = true;

            //} while (!userInputValid);

            //Console.WriteLine("Result: " + (userNum1 / userNum2));

            //Task 7: Repeating Menu with Exit Option

            Console.WriteLine("Menu Program: ");

            do
            {
                Console.WriteLine("1. Say Hello");
                Console.WriteLine("2. Show Current Time-of-day greeting");
                Console.WriteLine("3. Exit");

                try
                {

                    Console.WriteLine("Please choose an option: ");

                    int userChoice = int.Parse(Console.ReadLine());
                    switch (userChoice)
                    {
                        case 1:
                            Console.WriteLine("Hello!");
                            break;
                        case 2:
                            Console.WriteLine("Hello it's 10:30pm");
                            break;
                        case 3:
                            Console.WriteLine("Exiting the program.");
                            return;

                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }
            } while (true);


        }
    }
}
