// CSE 210 - Introduction to Programming
// Exercise 1 - Practice with Program to build the Cycling Derived class and test functionality of base class and inheritance and overriding methods.
// Author: Tom Gibb
// Date: 06-15-2026

// The Cycling derived class will be the class. This will be the base class and further derived classes to demonstrate inheritance and method overriding.
// The program will also test the functionality of the classes by calling their methods and displaying the results to the console.
// There will be no user input or output except the report on data as programmed into the application.


using System.Diagnostics;

internal class Cycling(string operationName = "Cycling", int duration = 0, double distance = 0.0) : Activity(operationName, duration, distance)
{
     protected double Distance { get; } = distance;
     protected int Duration { get; } = duration;
     protected string Operation { get; } = operationName;
     private double minuteMile = 0.0;
     private double milesPerHour = 0.0;

     public void StartActivity()
     {
          minuteMile = Distance / 60;
          milesPerHour = minuteMile / 60;

          Console.WriteLine($"You cycled {Distance} miles in {Duration}. This equates to cycling at a pace of {minuteMile} per mile");
          Console.WriteLine($"Your speed was {milesPerHour}");
     }

}
