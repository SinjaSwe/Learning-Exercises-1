using Microsoft.VisualBasic;
using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
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
                        case 11:
                            RunExerciseEleven();
                            break;
                        case 12:
                            RunExerciseTwelve();
                            break;
                        case 18:
                            RunExercise18();
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


                RunExerciseEleven();

                static void RunExerciseEleven()

                {
                    int number;

                    Console.WriteLine(" Enter an integer number:");
                    number = Convert.ToInt32(Console.ReadLine());

                    if (number < 0)

                    {
                        Console.WriteLine("Error! Error! Error!");
                    }
                        
                    else
                    {
                        Console.WriteLine("Well done!");
                    }

                   for (int i = 0; i<=10; i++)

                    {
                        Console.WriteLine(i);

                        if (i % 2 == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else
                        {
                           Console.ForegroundColor = ConsoleColor.Red;
                        }

                    }

                   for (int i = 10; i>=0; i--)
                    {
                        Console.WriteLine(i);

                        if (i % 2 == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                    }

                }

                RunExerciseTwelve();

                static void RunExerciseTwelve()
                {

                    for (int i=1; i<10;i++)
                    {
                        for (int j = 0; j <=10; j++)
                        {
                            Console.WriteLine("{0}x{1} = {2}", i, j, i * j);
                        }
                        Console.WriteLine("===================");
                    }
                    Console.ReadKey();


                }

                RunExercise18();

                static void RunExercise18()

                {
                    int Min = 0;
                    int Max = 125;
                    
                    int[] elements = new int[10]; // create a new array

                    Random randno = new Random();
                    
                    for (int x = 0; x < elements.Length; x++)
                    {
                        elements[x] = randno.Next(Min, Max);
                    }

                    foreach (var item in elements) // renames the elements temp to create them in the foreach loop to print
                    {
                        Console.WriteLine(item);
                        //Console.WriteLine(1.0 / item);
                    }

                    // Step 2: Create an empty array


                    double[] empty1 = new double[10]; // create a new array
                    double temp; //define a double


                    for (int x = 0; x < elements.Length; x++) // loop through the first array as you are using those int so it's a copy of the above
                    {
                        temp = 1.0 / elements[x]; // keep x as not in the same loop. Otherwise would need to change
                        empty1[x] = temp; // creates the new array by applying the temp values into the new array
                        Console.WriteLine("test: " + temp);

                        //Console.WriteLine(temp);
                    }

                    for (int x = 0; x < empty1.Length; x++)
                    {
                        Console.WriteLine(empty1[x]);
                    }

                    /*for (double y = 0; y == 10; y++)

                        
                    {
                        Console.WriteLine("Divison into 1{0} = {1}", y, (Convert.ToDouble(elements))[y]);
                    }

                 
                    
   //var empty1 = new double[10];

                                       /*
                    for (int y = 0; y < empty1.Length; y++)

                    {

                        {
                            table[y, x] = empty1 / elements;
                        }


                        // return  / elements;
                    }

        static void SetMultiNumbers(double[,] table)
        {
            for (double y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    table[y, x] = (y + 1) * (x + 1);
                }
            }
        }



        
         * foreach (var)



        Console.WriteLine(empty1.Length == 0);

        // Divide 

        double result = DivideOne(empty1);
        Console.WriteLine("Output: {0}", result);

        static double DivideOne (double[] array)
        {
            return empty1[0] / elements;

         }



        {
            // Step 1: create 3-element array.
            int[] array = { -5, -6, -7 };

            // Step 2: pass array reference to method.
            int result = MultiplyFirstElement(array);
            Console.WriteLine("FIRST ELEMENT MULTIPLIED: {0}", result);
        }

        static int MultiplyFirstElement(int[] array)
        {
            // Step 3: multiply the first element by 2 and return it.
            return array[0] * 2;
        }*/






                }





            }


        }

        
    }

    }



