// CSE 210 - Introduction to Programming
// Exercise 1 - Practice with ReflectingActivity Class
// Author: Tom Gibb
// Date: 06/06/2026

// The Reflection class will be derived from the Activity class and will contain the following properties:
// - _prompts: a list of strings that will be used to store the reflection prompts.
// - _questions: a list of strings that will be used to store the reflection questions.

// The Reflection class will contain the following methods:
// - Reflection(): a constructor that will be used to initialize the properties of the Reflection class. This constructor will take in the name, description, duration, prompts, and questions as parameters and will initialize the properties of the class with the provided values.
// - Run(): a method that will be used to start the reflection activity. This method will display the name and description of the activity, and will start a timer that will run for the duration of the activity. This method will also display the reflection prompt to the user.
// - GetRandomPrompt(): a method that will be used to get a random reflection prompt from the list of prompts. This method will return a random reflection prompt as a string.
// - GetRandomQuestion(): a method that will be used to get a random reflection question from the list of questions. This method will return a random reflection question as a string.
// - DisplayPrompts(): a method that will be used to display the reflection prompts to the user. This method will display a list of prompts that the user can choose from, and will return the selected prompt as a string.
// - DisplayQuestions(): a method that will be used to display the reflection questions to the user. This method will display a list of questions that the user can choose from, and will return the selected question as a string.

using System;
using System.Collections.Generic;
using System.IO;


class Reflection : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public Reflection(string name, string description, int duration, List<string> prompts, List<string> questions) : base(name, description, duration)
    {
        _prompts = prompts;
        _questions = questions;
    }

    public void Run()
    {
        Start();
        Console.WriteLine("Reflection Prompt: " + GetRandomPrompt());
        Console.WriteLine("Reflection Question: " + GetRandomQuestion());
        End();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    private string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    public string DisplayPrompts()
    {
        Console.WriteLine("Reflection Prompts:");
        for (int i = 0; i < _prompts.Count; i++)
        {
            Console.WriteLine((i + 1) + ". " + _prompts[i]);
        }
        Console.Write("Select a prompt by entering the corresponding number: ");
        int selection = int.Parse(Console.ReadLine());
        return _prompts[selection - 1];
    }

    public string DisplayQuestions()
    {
        Console.WriteLine("Reflection Questions:");
        for (int i = 0; i < _questions.Count; i++)
        {
            Console.WriteLine((i + 1) + ". " + _questions[i]);
        }
        Console.Write("Select a question by entering the corresponding number: ");
        int selection = int.Parse(Console.ReadLine());
        return _questions[selection - 1];
    }
}