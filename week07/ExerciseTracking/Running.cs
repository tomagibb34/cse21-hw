// CSE 210 - Introduction to Programming
// Exercise 1 - Practice with Program to build the Running Derived class and test functionality of base class and inheritance and overriding methods.
// Author: Tom Gibb
// Date: 06-15-2026

// The Running derived class will be the class. This will be the base class and further derived classes to demonstrate inheritance and method overriding.
// The program will also test the functionality of the classes by calling their methods and displaying the results to the console.
// There will be no user input or output except the report on data as programmed into the application.
//
//

using System;
using System.Diagnostics;

internal class Running(string operationName, int durationTime, double distance) : Activity(operationName, durationTime, distance)
{
    private string _operationName = operationName;
    private int _durationTime = durationTime;
    private double _distance = distance;
    private double minuteMile = 0.0;

    public void StartActivity()
    {
        minuteMile = _distance / 60;

        Console.WriteLine($"You ran {_distance} miles in {_durationTime}. This equates to running at a pace of {minuteMile} per mile");
    }
}

