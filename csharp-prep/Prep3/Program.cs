using System;

class Program
{
    static void Main(string[] args)

    
    {

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        
         int userGuessNumber = -1;
        
        while (userGuessNumber != magicNumber)
        {
            Console.Write("What is your guess? ");
            userGuessNumber = int.Parse(Console.ReadLine());
        
            if (userGuessNumber < magicNumber)
            {
                Console.WriteLine ("Higher");
            }
            else if (userGuessNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } 
    }
}