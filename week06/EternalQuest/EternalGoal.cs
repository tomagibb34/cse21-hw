// CSE 210 - Introduction to Programming
// Exercise 1 - Practice with Program is a part of the EternalQuest project with this being the EternalGoal Class and obtains elements from the base Goal class and test functionality of base class and inheritance and overriding methods.
// Author: Tom Gibb
// Date: 06-12-2026

// This program is the EternalGoal Class for the EternalQuest project.
// The EternalGoal class will inherit from the Goal base class and represent a specific type of goal within the EternalQuest project.
// It will override the methods from the Goal base class to provide specific behavior for an eternal goal, such as allowing for multiple completions and calculating the score based on the number of times the goal has been completed.
// The EternalGoal class will include properties and methods specific to an eternal goal, such as an integer property to track the number of times the goal has been completed and a method to calculate the score based on this count.
// The EternalGoal class will utilize the properties and methods of the Goal base class to provide a structured and organized way to manage eternal goals within the EternalQuest project, allowing for code reuse and extensibility through inheritance.
// Properties;
// - completionCount: An integer property that tracks the number of times the eternal goal has been completed.
// Methods:
// - EternalGoal(string name, string description, string points): A constructor that initializes the eternal goal with the provided name, description, and points, and sets the completionCount property to zero by default.
// - RecordEvent(): An overridden method that increments the completionCount property each time it is called, allowing for tracking the number of times the eternal goal has been completed within the EternalQuest project.
// - GetStringRepresentation(): An overridden method that returns a string containing the details of the eternal goal, including the name, description, points, and the number of times it has been completed, allowing for easy display and management of the goal within the EternalQuest project.
// - IsComplete(): An overridden method that returns a boolean value indicating whether the eternal goal has been completed at least once, allowing for conditional logic based on the completion status of the goal within the EternalQuest project.

using System;

class EternalGoal : Goal
{
    private int completionCount;

    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {
        completionCount = 0;
    }

    public override void RecordEvent()
    {
        completionCount++;
    }

    public override bool IsComplete()
    {
        return completionCount > 0;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal: {name}, Description: {description}, Points: {points}, Completion Count: {completionCount}";
    }
}
