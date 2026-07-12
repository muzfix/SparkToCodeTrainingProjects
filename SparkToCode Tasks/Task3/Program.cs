namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1 Absolute Difference
            //Console.WriteLine("Enter first number: ");
            //int userNum = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter second number: ");
            //int userNum2 = int.Parse(Console.ReadLine());

            //int subResult = userNum - userNum2;
            //Console.WriteLine("The absolute difference is: " + Math.Abs(subResult));

            //Task 2 Power & Root Explorer

            //Console.WriteLine("Enter a number: ");
            //double userNum = double.Parse(Console.ReadLine());

            //Console.WriteLine("The number " + userNum + " to the power of 2 is " + Math.Pow(userNum,2)  );
            //Console.WriteLine("The square root of " + userNum + " is " + Math.Sqrt(userNum));

            ////Task 3 Name Formatter
            //Console.WriteLine("Enter your full name: ");
            //string userName = Console.ReadLine();
            //Console.WriteLine("Your name in uppercase: " + userName.ToUpper());
            //Console.WriteLine("Your name in uppercase: " + userName.ToLower());
            //Console.WriteLine("The number of characters in the name you entered is: " + userName.Length);

            //Task 4 Subscription end date 
            Console.WriteLine("Enter the number of days for your trial that starts today: ");
            int userTrial = int.Parse(Console.ReadLine());
            DateTime trial = DateTime.Today.AddDays(userTrial);

            Console.WriteLine("Your trial starts today and ends on: " + trial.ToString("yyyy-MM-dd"));









        }
    }
}
