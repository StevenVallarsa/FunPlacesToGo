using System;

namespace FunPlacesToGo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! What are you in the mood to do?\n");
            Console.WriteLine("Choose one of these options:");
            Console.WriteLine("  1) Action");
            Console.WriteLine("  2) Chill Times");
            Console.WriteLine("  3) Danger");
            Console.WriteLine("  4) Good Food");
            Console.Write("\nWhat is your choice? ");

            bool isTrue = true;
            string action = "";
            string adventure = "";


            // make sure user put in one of the valid choices
            while (isTrue)
            {
                string choice = Console.ReadLine();


                switch (choice)
                {
                    case "1":
                        action = "action";
                        adventure = "stock car racing";
                        isTrue = false;
                        break;

                    case "2":
                        action = "chill times";
                        adventure = "hiking";
                        isTrue = false;
                        break;

                    case "3":
                        action = "danger";
                        adventure = "skydiving";
                        isTrue = false;
                        break;

                    case "4":
                        action = "good food";
                        adventure = "to Taco Bell";
                        isTrue = false;
                        break;

                    default:
                        Console.WriteLine("Oops. That wasn't one of the choice. Try again.");
                        Console.Write("Please choose a number between 1 and 4: ");
                        break;

                }
            }

            isTrue = true;
            int num = 0;

            Console.Write("\nHow many people are you bringing with you? ");


            // make sure user inputs an integer for number of people
            while (isTrue)
            {
                try
                {
                    num = int.Parse(Console.ReadLine());
                    isTrue = false;

                }
                catch (Exception)
                {
                    Console.Write("Oops. That wasn't a number. Try again: ");

                }


            }

            string trans = "";

            if (num == 0)
            {
                trans = "sneakers";
            }
            else if (num > 0 && num <= 4)
            {
                trans = "a sedan";
            }
            else if (num > 4 && num <= 10)
            {
                trans = "a Volkswagon bus";
            }
            else
            {
                trans = "an airplane";
            }

            Console.WriteLine("\nIf you're in the mood for " + action + ", " +
                "then you should go " + adventure + " and travel in " + trans + ".");
            Console.WriteLine("\nGoodbye!");
        }
    }
}
