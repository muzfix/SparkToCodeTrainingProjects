namespace LoopsPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Looping
            // 1- for loop => countable loop
            // 2- While loop => uncountable loop (conditional)
            //
            //For loop:
            // for(start; end; increment)
            // {
            //     code to be repeated
            // }

            int counter = 0;

            for(counter = 10; counter >= 5; counter--)
            {
                Console.WriteLine("!");
                Console.WriteLine("Certin message loop counter is at: " + counter);
            }

            ///////////////////////////////////////////////////////////////////////////

            bool exitDecision = false;
            int userChoice;
            string userInput;


            //while (exitDecision == false)
            do 
            {
                Console.WriteLine("print menu");

                
                try
                {
                    Console.WriteLine("Do you want to exit? (1/2)");
                    userChoice = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                Console.WriteLine("Do you want to exit? (y/n)");
                userInput = Console.ReadLine();

                if (userInput == "y")
                {
                    exitDecision = true;
                }
            } while (exitDecision == false);




        }
    }
}
