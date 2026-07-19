namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1: fixed grades array
            //int[] grades = new int[5];
            //for (int i = 0; i < grades.Length; i++)
            //{
            //    Console.WriteLine("enter a grade: ");
            //    grades[i] = int.Parse(Console.ReadLine());
            //}

            //foreach (int grade in grades)
            //{
            //    Console.WriteLine(grade);
            //}

            //Task 2: Dynamic To-Do List
            //List<string> list = new List<string>();

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Enter a task to add to the to-do list: ");
            //    list.Add(Console.ReadLine());

            //}
            //foreach (string s in list)
            //{
            //    Console.WriteLine("- "+ s);
            //}
            
            //Task 3: Browsing History Stack
            Stack<string> browserHistory = new Stack<string>();
            

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter a website URL: ");
                browserHistory.Push(Console.ReadLine());
            }
            browserHistory.Pop();
            Console.WriteLine(browserHistory.Peek());

        }
    }
}
