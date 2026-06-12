// CSE 210 - Introduction to Programming
// Exercise 1 - Practice with Program to utilize Circle Class and Inheritance
// Author: Tom Gibb
// Date: 06-11-2026

// This is a simple program that will be used to test the functionality of the Circle Class and Inheritance and Overriding.
// The Circle Class will be called "Circle" and will have the following properties and methods:
// 1. Properties:
//    a. Radius - The radius of the circle.
// 2. Methods:
//    a. GetArea() - Returns the area of the circle.
//    b. GetPerimeter() - Returns the circumference of the circle.
// 

using System;
class Circle(double radius) : Shape
{
     public double Radius { get; set; } = radius;

     public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }

    public override double GetPerimeter()
    {
        return 2 * Math.PI * Radius;
    }
}
