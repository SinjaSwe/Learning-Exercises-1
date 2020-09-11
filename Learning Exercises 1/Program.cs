using System;

namespace Learning_Exercises_1
{
    class Program
    {
        static void Main(string[] args)
        {
            RunExerciseOne();

            static void RunExerciseOne()
            {
                string firstname;
                string surname;

                Console.WriteLine("What is your firstname?");
                firstname = Console.ReadLine();

                Console.WriteLine("What is your surname?");
                surname = Console.ReadLine();

                Console.WriteLine("Hello " + firstname + " " +surname + "! I'm glad to inform you that you are the test subject of my very first assignment!");
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


            

            {

                

                






            }





        }
    } }
