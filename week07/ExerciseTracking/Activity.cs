// CSE 210 - Introduction to Programming
// Exercise 1 - Practice with Program to build the Activity class and test functionality of base class and inheritance and overriding methods.
// Author: Tom Gibb
// Date: 06-15-2026

// The Activity class will be the top level base class. This will be the base class and further derived classes to demonstrate inheritance and method overriding.
// The program will also test the functionality of the classes by calling their methods and displaying the results to the console.
// There will be no user input or output except the report on data as programmed into the application.
// Define protected variables that will be used by the three derived classes, Running, Swimming, and Cycling.
// Properties:
// - 
// 

using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

using static Program;

class Activity(string operationName, int DurationInMinutes, double distanceMiles)
{
     protected int TypeActivity;
     protected int DurationInMinutes;
     protected DateTime Date;
     protected string operationName = operationName;
     private string _tempInput = "";
     protected double distanceMiles = 0.0;
     protected int numberLaps = 0;
 
     public void Start()
     {
          TypeActivity = 0;

          while (TypeActivity != 4)
          {
               Console.WriteLine("What type of activity do you want to complete?");
               Console.WriteLine("Please select from the following Menu:");
               Console.WriteLine("For Swimming enter a 1");
               Console.WriteLine("For Running enter a 2");
               Console.WriteLine("For Cycling enter a 3 \b");
               Console.WriteLine("Enter a 4 to exit.");
               Console.WriteLine("Enter a 5 to repeat the activity input!");

               _tempInput = Console.ReadLine();
               if (!int.TryParse(_tempInput, out TypeActivity))
               {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    TypeActivity = 0; // continue loop
                    continue;
               }

               Console.WriteLine("What will be the duration of the activity?");

               if (TypeActivity == 1)
               {
                    operationName = "Swimming";
                    _tempInput = Console.ReadLine();
                    if (!int.TryParse(_tempInput, out DurationInMinutes))
                    {
                         Console.WriteLine("Invalid input. Please enter a valid duration number in units of minutes as an integer!");
                    }
                    Console.WriteLine("How many lap of the pool did you complete as an integer?");
                    _tempInput = Console.ReadLine();
                    if (!int.TryParse(_tempInput, out numberLaps))
                    {
                         Console.WriteLine("Invalid input. Please enter a valid number of laps as an integer!");
                    }

                    Swimming swimming = new(operationName, DurationInMinutes, numberLaps);
                    // To initiate the Swimming activity, call the Swimming instance's method here.
                    // For example, if Swimming exposes a method like StartActivity or GetSummary, use:

                    swimming.StartActivity();

               }
               else if (TypeActivity == 2)
               {
                    operationName = "Running";
                    _tempInput = Console.ReadLine();
                    if (!int.TryParse(_tempInput, out DurationInMinutes))
                    {
                         Console.WriteLine("Invalid input. Please enter a valid duration number in units of minutes as an integer!");
                    }
                    Console.WriteLine("How far did you run in miles, need a double value in the form of 2.5 or such?");
                    _tempInput = Console.ReadLine();
                    if (!double.TryParse(_tempInput, out distanceMiles))
                    {
                         Console.WriteLine("Invalid input. Please enter a valid distance number!");
                    }

                    Running running = new(operationName, DurationInMinutes, distanceMiles);

                    running.StartActivity();

               }
               else if (TypeActivity == 3)
               {
                    operationName = "Cycling";
                    _tempInput = Console.ReadLine();
                    if (!int.TryParse(_tempInput, out DurationInMinutes))
                    {
                         Console.WriteLine("Invalid input. Please enter a valid duration number in units of minutes as an integer!");
                    }
                    Console.WriteLine("How far did you cycle in miles, need a double value in the form of 2.5 or such?");
                    _tempInput = Console.ReadLine();
                    if (!double.TryParse(_tempInput, out distanceMiles))
                    {
                         Console.WriteLine("Invalid input. Please enter a valid distance number!");
                    }

                    Cycling cycling = new(operationName, DurationInMinutes, distanceMiles);

                    cycling.StartActivity();

               }
               else if (TypeActivity == 4)
               {
                    break;
               }
               else
               {
                    Console.WriteLine("Re-enter you choices! \b");
               }
          }
     }
}


