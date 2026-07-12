namespace FunctionsPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // built-in functions call 
            // className.functionName(parameters)

            Math.Cos(90);
            Math.Pow(2, 3);
            Console.WriteLine("Hello!");
            Console.Clear();
            double r = Math.Cos(90);
            Console.WriteLine(r);


            //////////////////

            Console.WriteLine("Enter number: ");
            float userInput = float.Parse(Console.ReadLine());

            double result = Math.Pow(2, 3); // 2^3 = 8
            Console.WriteLine(result);

            //////////////////

            Console.WriteLine("Enter base number: ");
            float baseNum = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter power number: ");
            float powerNum = float.Parse(Console.ReadLine());

            double result2 = Math.Pow(baseNum, powerNum);
            Console.WriteLine(result2);

            DateTime currentTiming = DateTime.Now;
            Console.WriteLine("Current date and time: " + currentTiming);

            DateTime timing = DateTime.Today;
            Console.WriteLine("Current date: " + timing);

            DateTime startSubscription = DateTime.Today;
            DateTime endSubscription = startSubscription.AddDays(30);
            Console.WriteLine("Subscription ends on: " + endSubscription);
            //////////////////////////////////////////////

            // String functions format
            // stringName.functionName(parameters)

            string word = "Hello, world!";
            int length = word.Length; //length 13. Special characters and spaces all count as a character
            word.Substring(7, 5); // returns "world"
            string upperedWord = word.ToUpper(); // returns "HELLO, WORLD!"
            string loweredWord = word.ToLower(); // returns "hello, world!"


            // a is different from A
            // ahmed is equal to AHMED is equal to Ahmed

            string name = "Ahmed";
            Console.WriteLine("Enter your name: ");
            string input = Console.ReadLine(); // ahmed wouldnt get accepted, how do we deal with this?


            if (input.ToUpper() == name.ToUpper())
            {
                Console.WriteLine("Welcome to the application, successful sign in " + name);
            }
            else
            {
                Console.WriteLine("Invalid name, please try again. ");

            }
            }
        }
    }
}
