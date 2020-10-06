using System;

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
                int randomNumber = rand.Next(4);
                switch (randomNumber)
                {
                    case 0:
                        {
                            Console.WriteLine("Yes!");
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine("No!");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Maybe so...");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Try again later!");
                            break;
                        }

                
            }

        }

    }
}
