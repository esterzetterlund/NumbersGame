using System.Security.Cryptography;

namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
          

            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök."); //Explain the game to the user

            Random randomNumber = new Random(); 
            int secretNumber = randomNumber.Next(1, 20);                                                       // picks a random number between 1-20
            int numberOfGuess = 0;                                                                             //users number in guesses
            int Guess;                                                                                         //users guess on the random number
            bool correct = false; 

            Console.WriteLine("Gissa på ett tal mellan 1 och 20!");                                            //Explain the game to the user

            while (numberOfGuess < 5 && !correct)                                                              //aslong they don´t guess 5 guesses and it´s not right
            {
                Console.Write("Gissning {0}:", numberOfGuess + 1);                                             //writes what guesses they are on
                Guess = Convert.ToInt32(Console.ReadLine());                                                   //users guess
                numberOfGuess++;                                                                               //add 1 to numbers of gusses

                if (Guess == secretNumber)                                                                     //is it right?
                {
                    correct = true;                                                                            // change to true
                    Console.WriteLine("Wohoo! Du klarade det!");                                               //Then write that they have right

                }
                else if (Guess > secretNumber)                                                                 //is it to high?
                {
                    Console.WriteLine("Oj, du gissade för högt, testa lite lägre!");                           //then write they should guess lower
                }
                else if (Guess < secretNumber)                                                                 //is it to low?
                {
                    Console.WriteLine("Oj, du gissade för lågt, testa lite högre!");                           //then write they should guess higher
                }
                


            }
            if (!correct)                                                                                      //if it is not right on the fifth try
            {
                Console.WriteLine("Tyvärr, du lyckades inte gissa talet på fem försök! Rätt nummer var {0}", secretNumber); //tell them which number it was
            }
            Console.ReadLine();
        }


    }
}