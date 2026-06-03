// CSE 210 - Introduction to Programming
// Exercise 1 - Practice with MathAssignment to utilize Base Class and Inheritance
// Author: Tom Gibb
// Date: 06-02-2026

// This is a simple program that will be used to test the functionality of the Base Class and Inheritance.
// The Base Class will be called "Assignment" and will have the following properties and methods:
// 1. Properties:
//    a. Name - The name of the assignment.
//    b. Description - A brief description of the assignment.
// 2. Methods:
//    a. GetSummary() - Returns the summary of the assignment.

// The Inheritance will be used to create a new class called "MathAssignment" that will inherit from the "Assignment" class.

// The "MathAssignment" class will have the following additional properties and methods:
// 1. Properties:
//    a. TextbookSection - The section of the textbook that the assignment is based on.
//    b. Problems - The list of problems that the assignment consists of.
// 2. Methods:
//    a. GetHomeworkList() - Returns the list of problems that the assignment consists of.

// The Inheritance will also be used to create a new class called "WritingAssignment" that will inherit from the "Assignment" class.

// The "WritingAssignment" class will have the following additional properties and methods:
// 1. Properties:
//    a. Title - The title of the writing assignment.
// 2. Methods:
//    a. GetSummary() - Returns the summary of the writing assignment.
//    b. GetStudentName() - Returns the name of the student who is submitting the assignment.
//    c. GetWritingInformation() - Returns the summary of the writing assignment along with the name of the student who is submitting the assignment.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class MathAssignment : Assignment
{
    private string _textbookSection;
    private List<string> _problems;

    public MathAssignment(string studentName, string topic, string textbookSection, List<string> problems)
    {
        _studentName = studentName;
        _topic = topic;
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public List<string> GetHomeworkList()
    {
        return _problems;
    }

    public void DisplayHomeworkList()   
    {
        Console.WriteLine($"Homework List for {_studentName}:");
        foreach (string problem in _problems)
        {
            Console.WriteLine($"- {problem}");
        }
    }
}