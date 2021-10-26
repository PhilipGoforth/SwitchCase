using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;
            while (playAgain)
            {
                Console.WriteLine("What is your favorite school subject?");
                string favCourse = Console.ReadLine();
                switch (favCourse)
                {
                    case "lunch":
                        Console.WriteLine($"{favCourse}? That's what I'm talking about!");
                        break;
                    case "science":
                        Console.WriteLine($"{favCourse} was fun for me too!");
                        break;
                    case "recess":
                        Console.WriteLine($"{favCourse} was one of my favorites too!");
                        break;
                    case "PE":
                        Console.WriteLine($"{favCourse}? You liked that class?");
                        break;
                    case "math":
                        Console.WriteLine($"Ah {favCourse}. I wasn't a fan myself...");
                        break;
                    default:
                        Console.WriteLine($"Oh {favCourse}. I dont have much to say about that subject!");
                        break;
                }
                Console.WriteLine("Any more subjects you liked? (y/n)");
                var answer = Console.ReadLine();
                playAgain = answer == "y" ?  true :  false;
            }
        }
    }
}
