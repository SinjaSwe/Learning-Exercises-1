using System;
using System.Runtime.InteropServices;
using System.Transactions;

namespace Learning_Exercises_1
{
    class Program
    {
        private static void RunExerciseOne()
        {
            Console.WriteLine("You successfully an exercise one!");
        }

        private static void RunExerciseTwo()
        {
            Console.WriteLine("You sucessfully ran exercise two!");
        }

        static void Main(string[] args)
        {

            var keepAlive = true;
            while (keepAlive)
            {
                try
                {
                    Console.Write("Enter assignment number (or -1 to exit): ");
                    var assignmentChoice = int.Parse(Console.ReadLine() ?? "");
                    Console.ForegroundColor = ConsoleColor.Green;
                    switch (assignmentChoice)
                    {
                        case 1:
                            RunExerciseOne();
                            break;
                        case 2:
                            RunExerciseTwo();
                            break;
                        case 3:
                            RunExerciseThree();
                            break;
                        case 4:
                            RunExerciseFour();
                            break;
                        case 5:
                            RunExerciseFive();
                            break;
                        case 6:
                            RunExerciseSix();
                            break;
                        case 7:
                            RunExerciseSeven();
                            break;
                        case 8:
                            RunExerciseEight();
                            break;
                        case 9:
                            RunExerciseNine();
                            break;
                        case 10:
                            RunExerciseTen();
                            break;
                        case -1:
                            keepAlive = false;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("This is not a valid assignment number!");
                            break;
                    }

                    Console.ResetColor();
                    Console.WriteLine("Hit any key to continue!");
                    Console.ReadKey();
                    Console.Clear();
                }

                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is not a valid assignment number!");
                    Console.ResetColor();
                }


                RunExerciseOne();

                static void RunExerciseOne()
                {
                    string firstname;
                    string surname;

                    Console.WriteLine("What is your firstname?");
                    firstname = Console.ReadLine();

                    Console.WriteLine("What is your surname?");
                    surname = Console.ReadLine();

                    Console.WriteLine("Hello " + firstname + " " + surname + "! I'm glad to inform you that you are the test subject of my very first assignment!");
                    Console.ReadLine();


                }

                RunExerciseTwo();

                static void RunExerciseTwo()
                {

                    //Today's date
                    Console.WriteLine("Today's date is: " + DateTime.Now.ToString("d/MM/yyyy"));

                    //Tomorrow's date
                    Console.WriteLine("Tomorrow's date is: " + DateTime.Now.AddDays(1).ToString("d/MM/yyyy"));

                    // Yesterday's date
                    Console.WriteLine("Yesterday's date was: " + DateTime.Now.AddDays(-1).ToString("d/MM/yyyy"));


                }


                RunExerciseThree();

                static void RunExerciseThree()

                {
                    string firstname;
                    string lastname;

                    Console.Write("Enter your firstname:");
                    firstname = Console.ReadLine();

                    Console.Write("Enter your lastname:");
                    lastname = Console.ReadLine();

                    var firstnameNew = firstname;
                    var lastnameNew = lastname;

                    Console.Write(firstnameNew + " " + lastnameNew);
                    Console.ReadLine();
                }


                RunExerciseFour();

                static void RunExerciseFour()
                {
                    String str = "The quick fox Jumped Over the DOG";
                    Console.WriteLine("OldString: " + str);
                    //replace the ending
                    Console.WriteLine("NewString: " + str.Replace("Over the DOG", "over the lazy dog."));
                }


                RunExerciseFive();

                static void RunExerciseFive()
                {
                    String str = "Arrays are very common in progamming, they look somethink like: [1,2,3,4,5]";
                    String newStr1 = str.Remove(0, 64);
                    String newStr2 = newStr1.Remove(2, 4);
                    Console.WriteLine("Original String: " + str);
                    Console.WriteLine("New string: " + newStr2.Insert(6, ",6,7,8,9,10"));
                }


                RunExerciseSix();

                static void RunExerciseSix()
                {

                    int firstNumber;
                    int secondNumber;

                    Console.Write("Enter your first number:");
                    firstNumber = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter your second number:");
                    secondNumber = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Biggest Number: " + Math.Max(firstNumber, secondNumber));
                    Console.WriteLine("Smallest Number: " + Math.Min(firstNumber, secondNumber));
                    Console.WriteLine("The difference is: " + (firstNumber - secondNumber));
                    Console.WriteLine("The sum is: " + (firstNumber + secondNumber));
                    Console.WriteLine("The product is: " + (firstNumber * secondNumber));
                    Console.WriteLine("The ratio is: " + (firstNumber / (double)secondNumber));
                    

                }

                RunExerciseSeven();

                static void RunExerciseSeven()
                {
                    double radius;
                    Console.Write("Enter the radius:");
                    radius = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("The area is(2 πr 2 ): " + (2 *(Math.PI*(radius*radius))));
                    Console.WriteLine("The volumn is:" + (4*(Math.PI*(radius*radius*radius))));
                    Console.ReadLine();
                }

                RunExerciseEight();

                static void RunExerciseEight()
                {
                    double number;
                    Console.Write("Enter a decimal number: ");
                    number = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("The square root of this number is: " + Math.Sqrt(number));
                    Console.WriteLine("The number to the power of 2 is: " + Math.Pow(number, 2));
                    Console.WriteLine("The number to the power of 10 is: " + Math.Pow(number, 10));
                    Console.ReadLine();
                 }

                RunExerciseNine();

                static void RunExerciseNine()

                {
                    int birthyear;
                    int age;
                    string firstname;
                    string answer = "Y";

                    Console.WriteLine("Welcome to Sinead's Irish Pub!");
                    Console.WriteLine("Welcome! What is your name? ");
                    firstname = Console.ReadLine();
                    Console.WriteLine("Welcome" + " " + firstname + " " + "to my pub!");
                    Console.WriteLine("What year were you born?");
                    birthyear = Convert.ToInt32(Console.ReadLine());
                    age = DateTime.Now.Year - birthyear;

                    // First if statement

                    if (age >= 18)
                    {
                        Console.WriteLine("Would you like a beer? Y or N");
                        answer = Console.ReadLine();


                        if (answer.Equals("Y"))
                        {
                            Console.WriteLine("Great! Your beer will be right over!");
                        }

                        else if (answer.Equals("N"))
                        {
                            Console.WriteLine("Would you like a coke instead?");
                            answer = Console.ReadLine();

                            if (answer.Equals("Y"))
                            {
                                Console.WriteLine("Ok, I'll get you a coke");
                            }

                            else
                            {
                                Console.WriteLine("That's a shame. You'll have to go thirsty!");
                            }
                        }

                    }

                    else if (age < 18)
                    {
                        Console.WriteLine("Would you like a coke? Y or N");
                        answer = Console.ReadLine();

                        if (answer.Equals("Y"))
                        {
                            Console.WriteLine("Ok, I'll get you a coke");
                        }

                        else
                        {
                            Console.WriteLine("That's a shame. You'll have to go thirsty!");
                        }

                    }

                }


                RunExerciseTen();

                static void RunExerciseTen()

                {                    
                Console.Write("----menu----\nEnter one of the following options: ?\n1\n2\n3\nSelection: ");
                string userInput = Console.ReadLine();             
                int numberA;
                int numberB;
                
                switch (userInput)

                    {
                        case "1":
                        Console.WriteLine("Enter a number:");
                        numberA = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter a number:");
                        numberB = Convert.ToInt32(Console.ReadLine());

                        if (numberB > 0)
                        {
                            Console.WriteLine("Your answer is: " + (numberA / numberB));
                        }

                        else 
                        {

                            Console.WriteLine("Error! You can not divide by zero!");
                        }

                        break;


                        /*case "2":
                            string caseTwo;

                            RunExerciseFour n = new RunExerciseFour();

                            //calling the FindMax method
                            caseTwo = n.RunExerciseFour;
                            Console.WriteLine(caseT);
                            Console.ReadLine();

                            Console.WriteLine(caseTwo);
                        break;
                        */

                        case "3":
                            
                            if (Console.BackgroundColor == ConsoleColor.Black)

                            { Console.BackgroundColor = ConsoleColor.Red;
                                Console.BackgroundColor = ConsoleColor.Green;
                                Console.Clear();

                                    }

                            break;


                            /*static void RunExerciseFour()
                            {
                                String str = "The quick fox Jumped Over the DOG";
                                Console.WriteLine("OldString: " + str);
                                //replace the ending
                                Console.WriteLine("NewString: " + str.Replace("Over the DOG", "over the lazy dog."));
                            }*/


                    }



                }




            }

                
            }

        private class RunExerciseFour
        {
        }
    }

    }



