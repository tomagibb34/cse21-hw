// CSE 210 - Introduction to Programming
// Exercise 1 - Practice with Program to build the Swimming Derived class and test functionality of base class and inheritance and overriding methods.
// Author: Tom Gibb
// Date: 06-15-2026

// The Swimming derived class will be the class. This will be the base class and further derived classes to demonstrate inheritance and method overriding.
// The program will also test the functionality of the classes by calling their methods and displaying the results to the console.
// There will be no user input or output except the report on data as programmed into the application.

using System;
using System.Diagnostics;

internal class Swimming(string operationName = "Swimming", int duration = 30, int numberLaps = 10) : Activity(operationName, duration, numberLaps)
{
     private int NumberLaps { get; } = numberLaps;
     private string OperationName { get; } = operationName;
     private int DurationTime { get; } = duration;
     private const double metersToFeet = 3.28084;
     private const int poolLength = 50; // Length in meters
     private double distanceSwam = 0.0;
     private double distanceSwamFeet = 0.0;
     private double lapsPerMinute = 0.0;

     public void StartActivity()
     {
          distanceSwam = NumberLaps * poolLength;
          distanceSwamFeet = distanceSwam * metersToFeet;
          // Convert distance swam from meters to feet

          lapsPerMinute = DurationTime / (double)NumberLaps;

          Console.WriteLine($"You swam {distanceSwamFeet} feet, and completed {NumberLaps} laps each 50 meters in length at the rate of {lapsPerMinute} per minute");

     }
}


