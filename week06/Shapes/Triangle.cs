// CSE 210 - Introduction to Programming
// Exercise 1 - Practice with Program to utilize Triangle Class and Inheritance and Override.
// Author: Tom Gibb
// Date: 06-11-2026

// This is a simple program that will be used to test the functionality of the Triangle Class and Inheritance and Overriding.
// The Triangle Class will inherit from the Shape Class and will have the following properties and methods:
// 1. Properties:
//    a. Base - The base of the triangle.
//    b. Height - The height of the triangle.
// 2. Methods:
//    a. GetArea() - Returns the area of the triangle.
//    b. GetPerimeter() - Returns the perimeter of the triangle.
using System;
class Triangle(double @base, double height) : Shape
{
     public double Base { get; set; } = @base;
     public double Height { get; set; } = height;

     public override double GetArea()
    {
        return 0.5 * Base * Height;
    }

    public override double GetPerimeter()
    {
        // Assuming an equilateral triangle for simplicity
        return 3 * Base;
    }
}    

