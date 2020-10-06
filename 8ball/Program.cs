using System;
using System.Threading;
using System.Linq;


namespace _8ball
{
    class Program
    {
        static void Main(string[] args)
        {
           
            GetQuestionsFromUser();
           
              
            
            QuestionLoop();
        }

        public static string GetQuestionsFromUser()
        {
            Console.WriteLine("what question do you have?");
            string questionString = Console.ReadLine();
            return questionString;
        }

        public static void QuestionLoop()
        {
                
                Random rand = new Random();

            Console.ForegroundColor = (ConsoleColor)rand.Next(15);
                int randomNumber = rand.Next(4);
                switch (randomNumber)
                {
                    case 0:
                        {
                        Console.ForegroundColor = (ConsoleColor)rand.Next(15);
                        Console.WriteLine("Yes!");
                            break;
                        }
                    case 1:
                        {
                        Console.ForegroundColor = (ConsoleColor)rand.Next(15);
                        Console.WriteLine("No!");
                            break;
                        }
                    case 2:
                        {
                        Console.ForegroundColor = (ConsoleColor)rand.Next(15);
                        Console.WriteLine("Maybe so...");
                            break;
                        }
                    case 3:
                        {
                        Console.ForegroundColor = (ConsoleColor)rand.Next(15);
                        Console.WriteLine("Try again later!");
                            break;
                        }
                    case 4:
                        {
                        Console.ForegroundColor = (ConsoleColor)rand.Next(15);
                        Console.WriteLine("Why are you bothering me??");
                            break;
                        }
                    case 5:
                        {
                        Console.ForegroundColor = (ConsoleColor)rand.Next(15);
                        Console.WriteLine("what? do you want me to solve all of your problems?!");
                            break;
                        }
                    case 6:
                        {
                        Console.ForegroundColor = (ConsoleColor)rand.Next(15);
                        Console.WriteLine("In your dreams!");
                            break;
                        }
                    case 7:
                        {
                        Console.ForegroundColor = (ConsoleColor)rand.Next(15);
                        Console.WriteLine("100%");
                            break;
                        }
                    case 8:
                        {
                        Console.ForegroundColor = (ConsoleColor)rand.Next(15);
                        Console.WriteLine("eh... maybe...?");
                            break;
                        }
                    case 9:
                        {
                        Console.ForegroundColor = (ConsoleColor)rand.Next(15);
                        Console.WriteLine("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
                            break;
                        }

            }

        }

    }
}
