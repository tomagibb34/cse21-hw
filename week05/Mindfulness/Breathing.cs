// CSE 210 - Introduction to Programming
// Exercise Mindfulness - Practice with BreathingActivity Class
// Author: Tom Gibb
// Date: 06/06/2026

// The BreathingActivity class will be derived from the Activity class and will contain the following properties:

// The BreathingActivity class will contain the following methods:
// - BreathingActivity(): a constructor that will be used to initialize the properties of the BreathingActivity class. This constructor will take in the name, description, duration, and breathing rate as parameters and will initialize the properties of the class with the provided values.
// - Run(): a method that will be used to start the breathing activity. This method will display the name and description of the activity, and will start a timer that will run for the duration of the activity. This method will also display a message that will prompt the user to breathe in and out at the specified breathing rate.

using System;

class Breathing : Activity
{
    protected static int _breathingRate;

    public Breathing(string name, string description, int duration, int breathingRate = 20) : base(name, description, duration)
    {
        _breathingRate = 60000 / breathingRate; // Convert breathing rate from breaths per minute to milliseconds per breath

        // Timer code  for the activity.

        while (GetDuration() > 0)
        {
            Console.WriteLine($"Breathe in... ({_breathingRate} breaths per minute)");

            Thread.Sleep(1000); // Sleep for the duration of one second to simulate the time taken for one breath
            _duration -= 1; // Decrease the duration by the time of one breath
            
            Thread.Sleep(_breathingRate); // Sleep for the duration of one breath

            Console.WriteLine("Breathe out...");
            Thread.Sleep(_breathingRate); // Sleep for the duration of one breath
            Console.Clear(); // Clear the console for the next breath prompt
        }
    }

    public void Run()
    {
        Start();
            Console.WriteLine($"Breathe in and out at a rate of {_breathingRate} breaths per minute.");
          // Here you would add code to handle the timing and prompts for breathing in and out.

          // Initiate a call to the Breathing Activity.

          var session = new Breathing("Breathing Activity", "This activity will help you relax by guiding you through slow breathing. Clear your mind and focus on your breath.", 60, 10);

            




        End();
    }

}