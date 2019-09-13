using System;

namespace NumberGuessingGame
{
    class Program
    {



        static int GetIntegerFromUser(string question)

        {

            int integerFromUser;
            bool success;


            do

            {

                Console.WriteLine(question);

                string userResponse = Console.ReadLine();

                success = int.TryParse(userResponse, out integerFromUser);

            } while (success == false);



            return integerFromUser;
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Let's play a guessing game! The higher your score, the worse you did!");
            Console.WriteLine("Start off by picking a value to pick from");

            int max = GetIntegerFromUser("What max range would you like?");

            Random rnd = new Random();
            int secretNumber = rnd.Next(1, max + 1);

            int guessNum = 0;
            int input = 0;
            do
            {
                guessNum = GetIntegerFromUser("Guess a Number Mate");

                if (guessNum < secretNumber)
                {
                    Console.WriteLine("This number that i am thinking is higher mate, Try Again!");
                    input++;
                   

                }
                else if (guessNum > secretNumber)
                {
                    Console.WriteLine("This number that i am thinking is lower mate, Try Again!");
                    input++;

                }

                else
                {
                    Console.WriteLine("Correct Bro You Have Special Powers!");
                    Console.WriteLine($"It took you {input} tries");
                }

                











            } while (guessNum != secretNumber);

            





        }
    }
}





