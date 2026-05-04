// CSE 210 - Introduction to Programming
// Exercise 3 - Magic Number guessing game
// Author: Tom Gibb
// Date: 03-05-2026

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This is the Magic Number Guessing Game exercise with a number range of 1 to 100.");

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        // Console.Write("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());

        int guessInteger = -1;

        while (guessInteger != magicNumber)
        {
            Console.Write("What is your guess? ");
            guessInteger = int.Parse(Console.ReadLine());
            if (guessInteger < magicNumber)
            {
                Console.WriteLine("Your guess is too low. Try again!");
            }
            else if (guessInteger > magicNumber)
            {
                Console.WriteLine("Your guess is too high. Try again!");
            }
            else
            {
                Console.WriteLine($"You guessed it! The magic number was {magicNumber}");
            }
        }
    }
}