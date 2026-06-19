// CSE 210 - Introduction to Programming
// Exercise 1 - Practice with Program is a part of the EternalQuest project with this being the CheckListGoal Class and obtains elements from the base Goal class and test functionality of base class and inheritance and overriding methods.
// Author: Tom Gibb
// Date: 06-12-2026

// This program is the CheckListGoal Class for the EternalQuest project.
// The CheckListGoal class will inherit from the Goal base class and represent a specific type of goal within the EternalQuest project.
// It will override the methods from the Goal base class to provide specific behavior for a checklist goal, such as tracking the number of times the goal has been completed and calculating the score based on this count.
// The CheckListGoal class will include properties and methods specific to a checklist goal, such as an integer property to track the number of times the goal has been completed, a method to calculate the score based on this count, and a method to determine if the checklist goal has been completed based on a predefined target count.
// The CheckListGoal class will utilize the properties and methods of the Goal base class to provide a structured and organized way to manage checklist goals within the EternalQuest project, allowing for code reuse and extensibility through inheritance.
// Properties:
// - amountCompleted: An integer property that tracks the number of times the checklist goal has been completed.
// - targetCount: An integer property that represents the target number of completions required to consider the checklist goal as completed.
// - bonusPoints: An integer property that represents the bonus points awarded when the checklist goal is completed.
// Methods:
// - CheckListGoal(string name, string description, string points, int targetCount, int bonusPoints): A constructor that initializes the checklist goal with the provided name, description, points, target count, and bonus points, and sets the amountCompleted property to zero by default.
// - IsComplete(): An overridden method that returns a boolean value indicating whether the checklist goal has been completed based on whether the amountCompleted property has reached or exceeded the targetCount property, allowing for conditional logic based on the completion status of the checklist goal within the EternalQuest project.
// - GetStringRepresentation(): An overridden method that returns a string containing the details of the checklist goal, including the name, description, points, target count, bonus points, and the number of times it has been completed, allowing for easy display and management of the checklist goal within the EternalQuest project.
// - RecordEvent(): An overridden method that increments the amountCompleted property each time it is called

using System;

class CheckListGoal : Goal
{
    private int amountCompleted;
    private readonly int targetCount;
    private readonly int bonusPoints;

    public CheckListGoal(string name, string description, string points, int targetCount, int bonusPoints) : base(name, description, points)
    {
        amountCompleted = 0;
        this.targetCount = targetCount;
        this.bonusPoints = bonusPoints;
    }

    public override bool IsComplete()
    {
        return amountCompleted >= targetCount;
    }

    public override string GetStringRepresentation()
    {
        return $"CheckListGoal: {name}, Description: {description}, Points: {points}, Target Count: {targetCount}, Bonus Points: {bonusPoints}, Amount Completed: {amountCompleted}";
    }

    public override void RecordEvent()
    {
        amountCompleted++;
        if (amountCompleted == targetCount)
        {
            points += bonusPoints;
        }
    }
}

