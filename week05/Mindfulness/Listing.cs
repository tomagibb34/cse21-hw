// CSE 210 - Introduction to Programming
// Exercise 1 - Practice with ListingActivity Class
// Author: Tom Gibb
// Date: 06/06/2026

// The ListingActivity class will be derived from the Activity class and will contain the following properties:
// - _count: an integer that will be used to store the count of the items that the user will list.
// - _prompts: List<string> that will be used to store the listing prompts.

// The ListingActivity class will contain the following methods:
// - ListingActivity(): a constructor that will be used to initialize the properties of the ListingActivity class. This constructor will take in the name, description, duration, count, and prompts as parameters and will initialize the properties of the class with the provided values.
// - Run(): a method that will be used to start the listing activity. This method will display the name and description of the activity, and will start a timer that will run for the duration of the activity. This method will also display the listing prompt to the user and will prompt the user to list as many items as they can that fit the prompt until the timer runs out.
// - GetRandomPrompt(): a method that will be used to get a random listing prompt from the list of prompts. This method will return a random listing prompt as a string.
// - GetListFromUser(): a method that will be used to get a list of items from the user based on the selected prompt. This method will return the list of items as a List<string>.

using System;
using System.Collections.Generic;

class Listing : Activity
{
    private int _count;
    private List<string> _prompts;

    public Listing(string name, string description, int duration, int count, List<string> prompts) : base(name, description, duration)
    {
        _count = count;
        _prompts = prompts;
    }

    public void Run()
    {
        Start();
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        List<string> items = GetListFromUser();
        End();
        Console.WriteLine($"You listed {items.Count} items!");
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    private List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            Console.Write("Enter an item: ");
            string item = Console.ReadLine();
            if (!string.IsNullOrEmpty(item))
            {
                items.Add(item);
            }
        }
        return items;
    }
}