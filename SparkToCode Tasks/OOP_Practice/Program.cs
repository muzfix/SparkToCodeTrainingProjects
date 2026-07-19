namespace OOP_Practice
{
    internal class Program
    {
        //class className
        //{

        //set of properties and methods / functions 
        //class is a blueprint of an object
        //class is a collection of properties and methods
        //class is a template for creating objects
        //class is a reference type

        //}

        public class BankAccount
        {
            // properties
            public int AccountNumber { get; set; }
            public string HolderName { get; set; }
            public double Balance { get; set; }

            //methods

            public void Deposit(double Amount)
            {
                Balance += Amount;
            }


            public void Withdraw(double amount)
            {
                if (Balance >= amount)
                {
                    Balance -= amount;
                }

            }

            public double CheckBalance()
            {
                return Balance;
            }
        }
        class Student
            {
                // properties (store multiple data / information)
                public int Grade { get; set; }
                public string Name { get; set; }
                public string Address { get; set; }
                private string email { get; set; } // private property,
                                                   // can only be accessed within the class
                int age { get; set; } // default access: private property; can only be accessed within the class

                //methods (functions)
            }


        static void Main(string[] args)
            {
            // variables (store individual data / single information)
            // primitive data types (int, string, float, double, char, bool)
            int grade1; // declare a variable of type int // stored in stack memory (fixed size)
            grade1 = 60; //assign a value to the variable
            string name1 = "John";
            string address1 = "Muscat";
            Console.WriteLine("Grade: " + grade1);

            //create an object of the class,
            //class is a user defined data type
            //object is an instance of the class
            Student s1 = new Student(); // declare variable or create an object of the class Student
                                            // stored in heap memory (dynamic size)
                                            // Student() is a constructor of the class Student

            s1.Name = "Ali";
            s1.Address = "Muscat";
            s1.Grade = 65;
            // s1.email = "muhannad@gmail"; // cannot be accessed; private property outside the class

            Console.WriteLine("Student Name: " + s1.Name);
            Console.WriteLine("Student Address: " + s1.Address);
            Console.WriteLine("Student Grade: " + s1.Grade);



            Student s2 = new Student();
            s2.Name = "Ahmed";
            s2.Address = "Muscat";
            s2.Grade = 70;

            /////////////////////////////////////////////////////////
            //Access Modifiers (public, private, protected, internal)
            /////////////////////////////////////////////////////////
                

            BankAccount B1 = new BankAccount();
            B1.AccountNumber = 1163;
            B1.HolderName = "Ahmed";
            B1.Balance = 120;

            double result1 = B1.CheckBalance();
            B1.Deposit(30);
            
            BankAccount B2 = new BankAccount();
            B2.AccountNumber = 15203;
            B2.HolderName = "Ali";
            B2.Balance = 63;

            double result2 = B2.CheckBalance();

            }
        }
    }

