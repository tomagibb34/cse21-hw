// CSE 210 - Introduction to Programming
// Exercise 1 - Practice with Program to build the Exercise Tracking program and test functionality of base class and inheritance and overriding methods.
// Author: Tom Gibb
// Date: 06-15-2026

// This program is the main entry point for the Exercise Tracking program. It will create instances of the base class and derived classes to demonstrate inheritance and method overriding.
// The program will also test the functionality of the classes by calling their methods and displaying the results to the console.
// There will be no user input or output except the report on data as programmed into the application.


using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        // Initiate the Activity Class directly

        Activity activity = new("Running", 30, 4.0);

        // To start the activity, call the Activity class Start method.
        // Call the Start method on the activity instance.
        
        activity.Start();
        
        
    }
}