namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Csharp fundamentals part 2
            // Task 1: Countdown Timer
            Console.WriteLine("Enter a number for the countdown: ");
            int countTimer = int.Parse(Console.ReadLine());
            for (int i = countTimer; i > 0; i--)
            {
                Console.WriteLine(i);
                if (i == 1)
                {
                    Console.WriteLine("Liftoff!");
                }
            }
        }
    }
}
