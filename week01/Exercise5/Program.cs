// CSE 210 - Introduction to Programming
// Exercise 5 - Practice with functions and methods
// Author: Tom Gibb
// Date: 05-04-2026
// This program demonstrates the use of functions and methods in C#. It will print a greeting message to the console.
// 1. Output a greeting message to the console using a function.
// 2. Create a function that takes a name as the input.
// 3. Create a function and queries the user for their favorite color and number.
// 4. Create a function that takes the user's favorite number and returns the square of that number.
// 5. Create a function that displays the users name, the square of their number, and their favorite color.



using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise 5 Project.");
        
        string userName = GetUserName();

        (string favoriteColor, int favoriteNumber) = GetUserPreferences();
        
        int squaredNumber = SquareNumber(favoriteNumber);
        
        DisplayUserInfo(userName, squaredNumber, favoriteColor);
    }

    // Function to get the user's name

    static string GetUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    // Function to get the user's favorite color and number
    static (string, int) GetUserPreferences()
    {
        Console.Write("Please enter your favorite color: ");
        string color = Console.ReadLine();

        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return (color, number);
    }

    // Function to calculate the square of a number
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Function to display user information
    static void DisplayUserInfo(string name, int squaredNumber, string favoriteColor)
    {
        Console.WriteLine($"Hello, {name}!");
        Console.WriteLine($"Your favorite color is {favoriteColor}.");
        Console.WriteLine($"The square of your favorite number is {squaredNumber}.");
    }
}