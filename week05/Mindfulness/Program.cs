// CSE 210 - Introduction to Programming
// Exercise 1 - Practice with Mindfulness Class
// Author: Tom Gibb
// Date: 06/06/2026

// This is a complex program that will be used to test the functionality of the Mindfulness class.
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

// The Breathing class will be derived from the Activity class and will contain the following properties:

// The Breathing class will contain the following methods:
// - Breathing(): a constructor that will be used to initialize the properties of the BreathingActivity class. This constructor will take in the name, description, duration, and breathing rate as parameters and will initialize the properties of the class with the provided values.
// - Run(): a method that will be used to start the breathing activity. This method will display the name and description of the activity, and will start a timer that will run for the duration of the activity. This method will also display a message that will prompt the user to breathe in and out at the specified breathing rate.

// The Reflection class will be derived from the Activity class and will contain the following properties:
// - _prompts: a list of strings that will be used to store the reflection prompts.
// - _questions: a list of strings that will be used to store the reflection questions.

// The Reflection class will contain the following methods:
// - Reflection(): a constructor that will be used to initialize the properties of the ReflectionActivity class. This constructor will take in the name, description, duration, prompts, and questions as parameters and will initialize the properties of the class with the provided values.
// - Run(): a method that will be used to start the reflection activity. This method will display the name and description of the activity, and will start a timer that will run for the duration of the activity. This method will also display the reflection prompt to the user.
// - GetRandomPrompt(): a method that will be used to get a random reflection prompt from the list of prompts. This method will return a random reflection prompt as a string.
// - GetRandomQuestion(): a method that will be used to get a random reflection question from the list of questions. This method will return a random reflection question as a string.
// - DisplayPrompts(): a method that will be used to display the reflection prompts to the user. This method will display a list of prompts that the user can choose from, and will return the selected prompt as a string.
// - DisplayQuestions(): a method that will be used to display the reflection questions to the user. This method will display a list of questions that the user can choose from, and will return the selected question as a string.

// The Listing class will be derived from the Activity class and will contain the following properties:
// - _count: an integer that will be used to store the count of the items that the user will list.
// - _prompts: List<string> that will be used to store the listing prompts.

// The Listing class will contain the following methods:
// - Listing(): a constructor that will be used to initialize the properties of the ListingActivity class. This constructor will take in the name, description, duration, count, and prompts as parameters and will initialize the properties of the class with the provided values.
// - Run(): a method that will be used to start the listing activity. This method will display the name and description of the activity, and will start a timer that will run for the duration of the activity. This method will also display the listing prompt to the user and will prompt the user to list as many items as they can that fit the prompt until the timer runs out.
// - GetRandomPrompt(): a method that will be used to get a random listing prompt from the list of prompts. This method will return a random listing prompt as a string.
// - GetListFromUser(): a method that will be used to get a list of items from the user based on the selected prompt. This method will return the list of items as a List<string>.



using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.IO;

class Program
{    
     protected static string _activityChoice;
     static void Main(string[] args)
     {
          Console.WriteLine("Hello World! This is the Homework Project.");


          Console.WriteLine("Hello World! This is the Mindfulness Project.");

          // Create an instance of the Activity class and call the Start() method to start the activity.
          // The Start() method will display the name and description of the activity, and will start a timer that will run for the duration of the activity.
          // The End() method will be called to end the activity. This method will stop the timer and will display a message that the activity has ended.
          // The GetDuration() method will be called to get the duration of the activity in seconds.
          // What activity does the user want to do?
          Console.WriteLine("What activity would you like to do?");
          Console.WriteLine("1. Breathing Activity");
          Console.WriteLine("2. Reflection Activity");
          Console.WriteLine("3. Listing Activity");
          Console.WriteLine("4. Quit");

          Console.Write("Enter the number of the activity you want to do: ");

          _activityChoice = Console.ReadLine() ?? "0";

          if (!int.TryParse(_activityChoice, out int choice))
          {
               Console.WriteLine("Invalid choice. Please enter a valid number between 1 and 4.");
               Thread.Sleep(10000); // Pause for 10 seconds before before clearing the screen and then exiting
               Console.Clear();
               return;
          }

          if (choice == 4)
          {
               Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye!");
               return;
          }
          else if (choice < 1 || choice > 4)
          {
               Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
               Thread.Sleep(10000); // Pause for 10 seconds before before clearing the screen and then exiting
               Console.Clear();
               return;
          }
          else
          {
               Console.WriteLine($"You have selected option {choice}. Let's get started!");
               if (choice == 1)
               {
                    // Create an instance of the Breathing class and call the Run() method to start the breathing activity.
                    Breathing breathing = new("Breathing Activity", "This activity will help you relax by guiding you through slow breathing exercises.", 60, 6);
                    breathing.Run();
               }
               else if (choice == 2)
               {
                    // Create an instance of the Reflection class and call the Run() method to start the reflection activity.
                    List<string> reflectionPrompts = ["Think about a time when you felt truly happy.", "Reflect on a recent challenge you overcame.", "Consider something you are grateful for today."];
                    List<string> reflectionQuestions = ["What made that moment special?", "How did you overcome that challenge?", "Why are you grateful for that?"];
                    Reflection reflection = new("Reflection Activity", "This activity will help you reflect on positive experiences and thoughts.", 120, reflectionPrompts, reflectionQuestions);
                    reflection.Run();
               }
               else if (choice == 3)
               {
                    // Create an instance of the Listing class and call the Run() method to start the listing activity.
                    List<string> listingPrompts = ["List as many things as you can that make you happy.", "List as many things as you can that you are grateful for.", "List as many things as you can that you have accomplished."];
                    Listing listing = new("Listing Activity", "This activity will help you focus on positive aspects of your life by listing them out.", 90, 0, listingPrompts);
                    listing.Run();
               }
          }
     
     Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye!");
     
    }
}
