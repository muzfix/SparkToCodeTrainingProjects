namespace Array_List_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // grades of students
            int grade1 = 85;
            int grade2 = 90;
            int grade3 = 78;
            int grade4 = 92;

            // collections (data structures) of variables
            // collection types: array, list, stack, queue, dictionary, set

            
            // single variable => holds a single value 
            int grade; // declare a variable to hodl a single grade
            grade = 85; // assign a value to the variable
            grade = 69; // reassign or change the value of the variable
            Console.WriteLine(grade); //print the value of the variable

            Console.WriteLine("Enter a grade: ");
            grade = int.Parse(Console.ReadLine());


            // ARRAY => FIXED SIZE, same data type, index based
            // a collection of integer values that is indexed
            // type[] arrayName = new type[size]; //syntax to declare an array
            int[] grades = new int[4]; // declare an array to hold 4 grades
            grades[0] = 85; // assigns value to the 1st element of the array
            grades[1] = 90; // assigns value to the 2nd element of the array
            grades[2] = 78;
            grades[3] = 92;

            grades[2] = 55; // reassign or change the value of the third element of the array
            Console.WriteLine(grades[2]);

            //alternative way to declare and initalize an array
            int[] grades2 = new int[] { 85, 90, 78, 92 }; //declare and initialize an array to hold 4 grades

            /////////////////////////////////////////////////////////
            // LIST => DYNAMIC SIZE, same data type, index based

            // List<type> listName = new List<type>(); // syntax to declare a list
            List<int> studentsGrades = new List<int>(); //declade a list to hold grades
            studentsGrades.Add(85); // add a value to the list
            studentsGrades.Add(90);
            studentsGrades.Add(78);
            studentsGrades.Add(92);

            studentsGrades[2] = 55; // reassign or change the value of the third element of the list
            Console.WriteLine(studentsGrades[2]);

            Console.WriteLine("Enter a grade: ");
            studentsGrades.Add(int.Parse(Console.ReadLine()));

            int length = studentsGrades.Count; //get the number of elements in the list

            Console.WriteLine(studentsGrades[length-1]); // print the value of the 5th (latest added) element of the list

            studentsGrades.Remove(55); //remove the first occurence of the VALUE 55 from list
            studentsGrades.RemoveAt(2); // remove the element at index 2 (AKA, the 3rd value in list)


            ////////////////////////////////////////////////////////////////////////////

            //Iterate over collections (array, list)
            // for loop

            int counter;
            for(counter = 0; counter < studentsGrades.Count; counter++) // count from 0 to length -1 ( < except last number)
            {
                Console.WriteLine(studentsGrades[counter]); // print the value of the element at index counter
            }

            // re initiate counter (set counter to 0) and iterate again
            for (counter = 0; counter < studentsGrades.Count; counter++) // reassignment for all values in the list
            {
                Console.WriteLine("Enter a grade: ");
                studentsGrades[counter] = int.Parse(Console.ReadLine());
            }

            for (counter = 0; counter < 10; counter++) // reassignment for all values in the list
            {
                Console.WriteLine("Enter a grade: ");
                studentsGrades.Add(int.Parse(Console.ReadLine()));
            }

            //removing any grade that is less than 50

            for (counter = 0; counter < studentsGrades.Count; counter++) // reassignment for all values in the list
            {
                if (studentsGrades[counter] < 50)
                {
                    studentsGrades.RemoveAt(counter);
                    counter--; //decrement counter to avoid skipping the next element after removal
                    // Dont forget this its so smart because when you remove something from the index
                    // it moves to the previous index position
                    //Therefore we reduce counter to CHECK so we dont miss something
                    //Karim Genius
                    //Alhamdulilah
                }
            }


            ////////////////////////////////////////////////////////////////////////////////////////
            // STACKS AND QUEUES

            //in stack and queue, the ORDER of elements is important
            //so we will use a different data structure to store them

            // Stack => dynamic size, same data type, LIFO (last in first out)
            // examples: undo/redo, browser history, call stack, etc
            //stack<type> stackName = new Stack<type>(); //syntax to declare a list

            Stack<string> browserHistory = new Stack<string>(); // declare stack to hold browser history
            browserHistory.Push("google.com"); //add a value to the stack
            browserHistory.Push("amazon.com"); //add a value to the stack
            browserHistory.Push("amazon.com/sell"); //add a value to the stack => Last In

            string result = browserHistory.Peek(); //get the value of the top element of the stack without removing it

            string result2 = browserHistory.Pop(); //remove the top element of the stack (amazon.com/sell) last out

            int stackLength = browserHistory.Count(); // get the num of elements in the stack

            //foreach syntax
            // foreach( type  varName  in collection collectionName  )

            // print all the elements in the stack using a foreach loop
            Console.WriteLine("Browser history: ");
            foreach (string url in browserHistory)
            {
                Console.WriteLine(url);
            }

            // Queue => dynamic size, same data type, FIFO (first in first out) / first come first serve
            // examples: customer service, ticketing system, print queue, etc. 
            //Queue<type> queueName = new Queue<type>(); //syntax to declare a queue 
            Queue<int> customerNumber = new Queue<int>();
            customerNumber.Enqueue(1); // adding customer number 1 to the queue => First In
            customerNumber.Enqueue(2); // adding customer number 2 to the queue
            customerNumber.Enqueue(3); // adding customer number 3 to the queue

            int firstCustomer = customerNumber.Peek(); // get the value of the first element of the queue without removing it
            int firstCustomerRemoved = customerNumber.Dequeue(); //Remove the first element of the queue (customer number 1) => First Out
            int queueLength = customerNumber.Count(); // get the number of elements in the queue

            //print all the elements in the queue using a foreach loop
            Console.WriteLine("Customer Numbers: ");
            foreach (int number in customerNumber)
            {
                Console.WriteLine(number);
            }

        }

    }
}
