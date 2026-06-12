// CSE 210 - Introduction to Programming
// Exercise 1 - Practice with Program to utilize Base Class and Inheritance
// Author: Tom Gibb
// Date: 06-11-2026

// This is a simple program that will be used to test the functionality of the Base Shape Class and Inheritance and Override.
// The Base Class will be called "Shape" and will have the following properties and methods:
// 1. Properties:
//    - Color (string)
// 2. Methods:
//    - GetColor() (string)
//    - SetColor(string color) (void)
//
//    - GetArea() (double)
//    - GetPerimeter() (double)
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Shape
{
    private string color;

    public string GetColor()
    {
        return color;
    }

    public void SetColor(string color)
    {
        this.color = color;
    }

    public virtual double GetArea()
    {
        return 0.0;
    }
    public virtual double GetPerimeter()
    {
        return 0.0;
    }
}
