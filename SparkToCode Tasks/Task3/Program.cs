namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1 Absolute Difference
            Console.WriteLine("Enter first number: ");
            int userNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int userNum2 = int.Parse(Console.ReadLine());

            int subResult = userNum - userNum2;
            Console.WriteLine("The absolute difference is: " + Math.Abs(subResult));


        }
    }
}
