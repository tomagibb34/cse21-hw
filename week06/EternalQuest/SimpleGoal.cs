// CSE 210 - Introduction to Programming
// Exercise 1 - Practice with Program is a part of the EternalQuest project with this being the SimpleGoal Class and obtains elements from the base Goal class and test functionality of base class and inheritance and overriding methods.
// Author: Tom Gibb
// Date: 06-12-2026

// This program is the SimpleGoal Class for the EternalQuest project.
// The SimpleGoal class will inherit from the Goal base class and represent a specific type of goal within the EternalQuest project.
// It will override the methods from the Goal base class to provide specific behavior for a simple goal, such as marking it as completed and calculating the score based on its completion status.
// The SimpleGoal class will include properties and methods specific to a simple goal, such as a boolean property to track whether the goal has been completed and a method to calculate the score based on the completion status of the goal.
// The SimpleGoal class will utilize the properties and methods of the Goal base class to provide a structured and organized way to manage simple goals within the EternalQuest project, allowing for code reuse and extensibility through inheritance.
// Properties:
// - isComplete: A boolean property that indicates whether the simple goal has been completed or not.
// Methods:
// - SimpleGoal(string name, string description, string points): A constructor that initializes the simple goal with the provided name, description, and points, and sets the isCompleted property to false by default.
// - RecordEvent(): An overridden method that marks the simple goal as completed when called, allowing for tracking the completion status of the goal within the EternalQuest project.
// - IsComplete(): An overridden method that returns a boolean value indicating whether the simple goal has been completed or not, allowing for conditional logic based on the completion status of the goal within the EternalQuest project.
// - GetStringRepresentation(): An overridden method that returns a string containing the details of the simple goal, allowing for easy display and management of the goal within the EternalQuest project.

using System;

class SimpleGoal(string name, string description, string points) : Goal(name, description, points)
{
    private bool isComplete = false;

     public override void RecordEvent()
    {
        isComplete = true;
    }

    public override bool IsComplete()
    {
        return isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal: {name}, Description: {description}, Points: {points}, Completed: {isComplete}";
    }
}

