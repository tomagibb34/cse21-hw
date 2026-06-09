// CSE 210 - Introduction to Programming
// Exercise 1 - Practice with Mindfulness Class
// Author: Tom Gibb
// Date: 06/06/2026

// This is a program will be used to test the functionality of the Activity as the Base class.
// The Activity class will be used as the base class for the BreathingActivity, ReflectionActivity, and ListingActivity classes.
// The Activity class will contain the common properties and methods that will be used by the derived classes.

// The Activity class will contain the following properties:
// - _name: a string that will be used to store the name of the activity.
// - _description: a string that will be used to store the description of the activity.
// - _duration: an integer that will be used to store the duration of the activity in seconds

// The Activity class will contain the following methods:
// - Start(): a method that will be used to start the activity. This method will display the name and description of the activity, and will start a timer that will run for the duration of the activity.
// - End(): a method that will be used to end the activity. This method will stop the timer and will display a message that the activity has ended.
// - GetDuration(): a method that will be used to get the duration of the activity in seconds. This method will return the duration of the activity in seconds.
// - ShowSpinner(): a method that will be used to display a spinner animation while the activity is running. This method will display a spinner animation in the console while the timer is running for the duration of the activity.
// - ShowCountdown(): a method that will be used to display a countdown timer while the activity is running. This method will display a countdown timer in the console while the timer is running for the duration of the activity.

// The BreathingActivity class will be derived from the Activity class and will contain the following properties:

// The BreathingActivity class will contain the following methods:
// - BreathingActivity(): a constructor that will be used to initialize the properties of the BreathingActivity class. This constructor will take in the name, description, duration, and breathing rate as parameters and will initialize the properties of the class with the provided values.
// - Run(): a method that will be used to start the breathing activity. This method will display the name and description of the activity, and will start a timer that will run for the duration of the activity. This method will also display a message that will prompt the user to breathe in and out at the specified breathing rate.

// The ReflectionActivity class will be derived from the Activity class and will contain the following properties:
// - _prompts: a list of strings that will be used to store the reflection prompts.
// - _questions: a list of strings that will be used to store the reflection questions.

// The ReflectionActivity class will contain the following methods:
// - ReflectionActivity(): a constructor that will be used to initialize the properties of the ReflectionActivity class. This constructor will take in the name, description, duration, prompts, and questions as parameters and will initialize the properties of the class with the provided values.
// - Run(): a method that will be used to start the reflection activity. This method will display the name and description of the activity, and will start a timer that will run for the duration of the activity. This method will also display the reflection prompt to the user.
// - GetRandomPrompt(): a method that will be used to get a random reflection prompt from the list of prompts. This method will return a random reflection prompt as a string.
// - GetRandomQuestion(): a method that will be used to get a random reflection question from the list of questions. This method will return a random reflection question as a string.
// - DisplayPrompts(): a method that will be used to display the reflection prompts to the user. This method will display a list of prompts that the user can choose from, and will return the selected prompt as a string.
// - DisplayQuestions(): a method that will be used to display the reflection questions to the user. This method will display a list of questions that the user can choose from, and will return the selected question as a string.

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

class Activity
{
    protected string _name = string.Empty;
    protected string _description = string.Empty;
    protected int _duration = 0;

    public Activity(string name, string description, int duration)
    {
        // Initialize fields from constructor parameters
        _name = name;
        _description = description;
        _duration = duration;
        
    }

    public void Start()
    {
        Console.WriteLine($"Starting {_name} activity...");
        Console.WriteLine(_description);
        // Start timer for the duration of the activity
    }

    public void End()
    {
        Console.WriteLine($"Ending {_name} activity...");
        // Stop timer and display message that the activity has ended
    }

    public int GetDuration()
    {
        Console.WriteLine($"Setting duration for {_name} activity...");
        Console.Write("Enter the duration of the activity in seconds: ");
        var input = Console.ReadLine();
        if (!int.TryParse(input, out _duration) || _duration < 0)
        {
            Console.WriteLine("Invalid input. Using default duration 30.");
            _duration = 30;
        }

        return _duration;
    }
     public static void ShowSpinner(int _duration)
     {
          // Display spinner animation in the console while the timer is running for the duration of the activity
          // Implementation for spinner animation
          while (_duration > 0)
          {
              Console.Write("|");
              System.Threading.Thread.Sleep(100);
              Console.Write("\b/");
              System.Threading.Thread.Sleep(100);
              Console.Write("\b-");
              System.Threading.Thread.Sleep(100);
              Console.Write("\b\\");
              System.Threading.Thread.Sleep(100);
              Console.Write("\b");
              _duration -= 400;
          }

     }
}
