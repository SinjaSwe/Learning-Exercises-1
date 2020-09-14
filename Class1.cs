using System;

public partial class Program
{
	public partial class Program()
	{

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

            RunExercise18();

            static void RunExercise18()

                int[] emptyIntArray = new int[10];
            Console.WriteLine(Int);







        }



    }
}
