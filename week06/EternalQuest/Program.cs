// CSE 210 - Introduction to Programming
// Exercise 1 - Practice with Program to utilize EternalQuest project and test functionality of base class and inheritance and overriding methods.
// Author: Tom Gibb
// Date: 06-12-2026

// This program is the main entry point for the EternalQuest project. It will create instances of the base class and derived classes to demonstrate inheritance and method overriding. The program will also test the functionality of the classes by calling their methods and displaying the results to the console.



using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");

        // Instantiate the Goal base class
        
        Goal baseGoal = new("Base Goal", "This is the base goal description.", "100");
        baseGoal.DisplayGoalInfo();
        Console.WriteLine(baseGoal.GetDetailsString());
        Console.WriteLine(baseGoal.GetStringRepresentation());


    }
}