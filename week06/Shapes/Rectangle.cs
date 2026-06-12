// CSE 210 - Introduction to Programming
// Exercise 1 - Practice with Program to utilize Rectangle class and inheritance and overriding methods.
// Author: Tom Gibb
// Date: 06-11-2026

// This is a simple program that serves as Rectangle class.
// It inherits from the Shape class and overrides the methods to calculate area and perimeter for a rectangle. The Rectangle class has two properties: width and length, which are used in the calculations.
// The area of a rectangle is calculated as width multiplied by length, and the perimeter is calculated as 2 times the sum of width and length.
// The class also includes a constructor to initialize the width and length properties when a new Rectangle object is created.
// 1. Properties:
//    a. Width - The width of the rectangle.
//    b. Length - The length of the rectangle.
// 2. Methods:
//    a. GetArea() - Returns the area of the rectangle.
//    b. GetPerimeter() - Returns the perimeter of the rectangle.

using System;
class Rectangle(double width, double length) : Shape
{
     public double Width { get; set; } = width;
     public double Length { get; set; } = length;

     public override double GetArea()
    {
        return Width * Length;
    }

    public override double GetPerimeter()
    {
        return 2 * (Width + Length);
    }
}
