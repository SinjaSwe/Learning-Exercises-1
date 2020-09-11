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
                    Console.WriteLine("Enter assignment number (or -1 to exit): ");
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






            }
        }

    }

}