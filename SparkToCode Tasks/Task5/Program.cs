namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1: fixed grades array
            int[] grades = new int[5];
            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine("enter a grade: ");
                grades[i] = int.Parse(Console.ReadLine());
            }

            foreach (int grade in grades)
            {
                Console.WriteLine(grade);
            }
        }
    }
}
