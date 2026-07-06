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

        }
    }
}
