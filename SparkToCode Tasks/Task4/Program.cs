namespace Task4
{
    internal class Program
    {
        //Task 1 Print Welcome Message
        static void PrintWelcome(string userName)
        {
            Console.WriteLine("Welcome, " + userName + " to the app!");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name: ");
            string userName = Console.ReadLine();

            Program.PrintWelcome(userName);


        }
    }
}
