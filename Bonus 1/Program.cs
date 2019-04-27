using System;

namespace Bonus_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            PromptUser();
        }
        public static Boolean Continue()
        {
            Console.WriteLine("Continue? y/n");
            string input = Console.ReadLine();
            Boolean run = false;
            input.ToLower();

            if (input == "n")
            {
                Console.WriteLine("Goodbye.");
                run = false;
            }
            else if (input == "y")
            {
                run = true;
                PromptUser();
            }
            else
            {
                Console.WriteLine("I'm sorry. I didn't understand your input. Let's try that again.");
                run = Continue();

            }
            return run;
        }


        public static void PromptUser()
        {
            int input;

            Console.WriteLine("Welcome to the Letter Grade Converter!\n");
            Console.WriteLine("Enter a numerical grade: ");
            input = Convert.ToInt32(Console.ReadLine());

            if (input >= 0 && input <= 60)
            {
                Console.WriteLine("Letter Grade: F");
            }
            else if (input > 60 && input <= 66)
                Console.WriteLine("Letter Grade: D");
            else if (input > 66 && input <= 79)
                Console.WriteLine("Letter Grade: C");
            else if (input > 79 && input <= 87)
                Console.WriteLine("Letter Grade: B");
            else if (input > 88 && input <= 100)
                Console.WriteLine("Letter Grade: A");
            else
                Console.WriteLine("I'm sorry. I didn't understand your input. Continue? (y/n)");
            Continue();

        }
    }
}
