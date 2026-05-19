// CSE 210 - Introduction to Programming
// Exercise 1 - Practice with fractions
// Author: Tom Gibb
// Date: 05-14-2026

// Create a new C# console application project named "Fractions".
// In this project, you will create a class called "Fraction" that represents a fraction with a numerator and denominator.
// The class should include methods for performing operations on fractions, such as addition, subtraction, multiplication, and division.
// You should also include methods for simplifying the fraction and converting it to a decimal.

// In the Main method of your program, create instances of the Fraction class and demonstrate the functionality of the methods you have implemented.
// For example, you can create two fractions, perform operations on them, and display the results to the console.

// Verify that you can utilize the constructors to create fractions with different initial values, and that the ToString() method correctly displays the fraction in a readable format. 
// Utilize the getters and setters for both the numerator and denominator to ensure that the values are correctly assigned and retrieved.

// Create a method called Get FractionsString that returns the fraction in the for 3/4 as "3/4". This method should be used in the ToString() method to display the fraction in a readable format. 
//Create a method called GetDecimalValue that returns a double that is ThreadExceptionEventArgs result of dividing the numerator by denominator. This method should be used to convert the fraction to a decimal value.
// Verify that you can call each constructor and that you retrieve and display the different representations for a few different fractions
// Such as 1/2, 3/4, and 5/6.
//For example, you can create a fraction with the default constructor, one with just a numerator, and one with both a numerator and denominator.
//Then, display the fraction using the ToString() method and also display its decimal value using the GetDecimalValue() method.



using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.IO;

using System.Globalization;
using System.Threading;
using static Fraction;



class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        // Create some fractions using different constructors

        Fraction fraction1 = new Fraction(); // Default constructor (1/1)
        Fraction fraction2 = new Fraction(3); // Constructor with numerator only (3/1)
        Fraction fraction3 = new Fraction(5, 6); // Constructor with both numerator and denominator (5/6)

        // Display the fractions and their decimal values

        Console.WriteLine($"Fraction 1: {fraction1.GetFractionsString()} = {fraction1.GetDecimalValue()}");
        Console.WriteLine($"Fraction 2: {fraction2.GetFractionsString()} = {fraction2.GetDecimalValue()}");
        Console.WriteLine($"Fraction 3: {fraction3.GetFractionsString()} = {fraction3.GetDecimalValue()}");

        // Create more fractions to demonstrate operations

        Fraction fraction4 = new Fraction(1, 2); // 1/2
        Fraction fraction5 = new Fraction(3, 4); // 3/4

        // Display the fractions and their decimal values
        Console.WriteLine($"Fraction 4: {fraction4.GetFractionsString()} = {fraction4.GetDecimalValue()}");
        Console.WriteLine($"Fraction 5: {fraction5.GetFractionsString()} = {fraction5.GetDecimalValue()}");


        // Here you can add code to demonstrate addition, subtraction, multiplication, and division of fractions once those methods are implemented in the Fraction class.


    }
}