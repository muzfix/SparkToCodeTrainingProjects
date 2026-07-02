using Microsoft.VisualBasic.FileIO;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Xml;

namespace CsharpFundamentalsPart1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // Task 1:
            // Create a console application that prompts the user for their name, age, height, and whether they are a student.
            // Then display the collected information back to the user.

            //Console.WriteLine("Enter your name: ");
            //string userName = Console.ReadLine();

            //Console.WriteLine("Enter your age: ");
            //int userAge = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter your height in meters: ");
            //double userHeight = double.Parse(Console.ReadLine());

            //Console.WriteLine("Are you a student? (y/n): ");
            //string userInput = Console.ReadLine();
            //bool isStudent = false;
            //if(userInput == "y")
            //{
            //    Console.WriteLine("You are a student.");
            //}
            //else
            //{
            //    Console.WriteLine("You are not a student.");
            //}

            // Task 2: 
            // Rectangle Calculator
            // 

            //Console.WriteLine("Enter the length of the rectangle: ");
            //float rLength = float.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the width of the rectangle: ");
            //float rWidth = float.Parse(Console.ReadLine());

            //Console.WriteLine("The area of the rectangle is: " + (rLength * rWidth));
            //Console.WriteLine("The perimeter of the rectangle is: " + (2 * (rLength + rWidth)));

            // Task 3:
            // Even or Odd Checker

            //Console.WriteLine("Enter a number to check if it is odd or even: ");
            //float userNum = float.Parse(Console.ReadLine());

            //if (userNum % 2 == 0)
            //{
            //    Console.WriteLine("The number is even.");
            //}
            //else
            //{
            //    Console.WriteLine("The number is odd.");
            //}

            // Task 4: voting eligibility checker

            //Console.WriteLine("Enter your age to see if you are eligible to vote: ");
            //int userAge2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Do you have a valid national ID? (y/n)");
            //bool userInput2 = Console.ReadLine() == "y";

            //if (userAge2 >= 18 && userInput2 == true)
            //{
            //    Console.WriteLine("You are eligible to vote");
            //}
            //else
            //{
            //    Console.WriteLine("You are not eligible to vote");
            //}

            // Task 5:
            // Grade letter lookup

            //Console.WriteLine("Enter your grade letter to find out its meaning (A,B,C,D, or F): ");
            //string userGrade = Console.ReadLine();
            //switch (userGrade)
            //{
            //    case "A":
            //        Console.WriteLine("A = Excellent");
            //        break;

            //    case "B":
            //        Console.WriteLine("B = Very Good");
            //        break;

            //    case "C":
            //        Console.WriteLine("C = Good");
            //        break;

            //    case "D":
            //        Console.WriteLine("D = Pass");
            //        break;

            //    case "F":
            //        Console.WriteLine("F = Fail");
            //        break;
            //    default:
            //        Console.WriteLine("invalid grade");
            //        break;
            //}

            //Task 6:
            //Temperature Converter

            //Console.WriteLine("Enter the temp in Celsius: ");
            //float tempCelsius = float.Parse(Console.ReadLine());

            //float farenConverted = (tempCelsius * 9 / 5) + 32;
            //Console.WriteLine("The temperature in Fahrenheit is: " + farenConverted);

            //if (tempCelsius < 10)
            //{
            //    Console.WriteLine("Below 10. Cold.");
            //}
            //else if (tempCelsius > 10 && tempCelsius < 30)
            //{
            //    Console.WriteLine("Between 10 and 30. Mild.");
            //}
            //else if (tempCelsius > 30)
            //{
            //    Console.WriteLine("Above 30. Hot.");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid temperature.");
            //}

            // Task 7:
            // Movie Ticket Pricing

            //Console.WriteLine("Enter your age to find out your movie price: ");
            //int userAge3 = int.Parse(Console.ReadLine());

            //if (userAge3 >= 0 && userAge3 <= 12)
            //{
            //    Console.WriteLine("Children: Your ticket price is 2.000 OMR");
            //}
            //else if (userAge3 >= 13 && userAge3 <= 59)
            //{
            //    Console.WriteLine("Adults: Your ticket price is 5.000 OMR");
            //}
            //else if (userAge3 >= 60)
            //{
            //    Console.WriteLine("Seniors: Your ticket price is 3.000 OMR");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid age entered.");
            //}

            // Task 8:
            // Restaurant bill with membership discount

            //Console.WriteLine("Enter your bill amount: ");
            //float billAmount = float.Parse(Console.ReadLine());

            //Console.WriteLine("Are you a member? (y/n)");
            //bool isMember = Console.ReadLine() == "y";

            //if (billAmount > 20 && isMember == true)
            //{
            //    Console.WriteLine("You are a member and your bill is above 20. You get a 15% discount. Your total is: " + ((billAmount/100)*85));
            //}
            //else
            //{
            //    Console.WriteLine("Your price is: " + billAmount);
            //}

            // Task 9:
            // Day Name Finder

            //Console.WriteLine("Enter a number between 1 and 7 to find out its corresponding day of the week: ");
            //int dayNum = int.Parse(Console.ReadLine());

            //switch (dayNum)
            //{
            //    case 1:
            //        Console.WriteLine("1 = Sunday");
            //        break;
            //    case 2:
            //        Console.WriteLine("2 = Monday");
            //        break;
            //    case 3:
            //        Console.WriteLine("3 = Tuesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("4 = Wednesday");
            //        break;
            //    case 5:
            //        Console.WriteLine("5 = Thursday");
            //        break;
            //    case 6:
            //        Console.WriteLine("6 = Friday");
            //        break;
            //    case 7:
            //        Console.WriteLine("7 = Saturday");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid number entered.");
            //        break;
            //}

            // Task 10:
            // Mini Calculator

            Console.WriteLine("Enter the first number: ");
            float firstNum = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            float secondNum = float.Parse(Console.ReadLine());

            Console.WriteLine("+");
            Console.WriteLine("-");
            Console.WriteLine("*");
            Console.WriteLine("/");
            Console.WriteLine("%");

            Console.WriteLine("Please choose an option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "+":
                    Console.WriteLine(firstNum + secondNum);
                    break;

                case "-":
                    Console.WriteLine(firstNum - secondNum);
                    break;

                case "*":
                    Console.WriteLine(firstNum * secondNum);
                    break;

                case "/":
                    if (secondNum == 0)
                    {
                        Console.WriteLine("Cannot divide by zero");
                    }
                    else
                    {
                        Console.WriteLine(firstNum / secondNum);
                    }
                    break;
                     
                case "%":
                    if (secondNum == 0)
                    {
                        Console.WriteLine("Cannot divide by zero");
                    }
                    else
                    {
                        Console.WriteLine(firstNum / secondNum);
                    }
                    Console.WriteLine(firstNum % secondNum);
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }



        }
    }
}
