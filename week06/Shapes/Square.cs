// CSE 210 - Introduction to Programming
// Exercise 1 - Practice with Program to utilize Square Class and Inheritance
// Author: Tom Gibb
// Date: 06-02-2026

// This is a simple program that will be used to test the functionality of the Square Class and Inheritance and Overriding.
// The Square Class will be called "Square" and will have the following properties and methods:
// 1. Properties:
//    a. SideLength - The length of the sides of the square.
// 2. Methods:
//    a. GetArea() - Returns the area of the square.
//    b. GetPerimeter() - Returns the perimeter of the square.

using System;

class Square(double sideLength)
{
     public double SideLength { get; set; } = sideLength;

     public double GetArea()
    {
        return SideLength * SideLength;
    }

    public double GetPerimeter()
    {
        return 4 * SideLength;
    }
}
