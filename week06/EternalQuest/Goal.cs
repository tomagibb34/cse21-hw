// CSE 210 - Introduction to Programming
// Exercise 1 - Practice with Program to utilize EternalQuest project with this being the Goal Base Class and test functionality of base class and inheritance and overriding methods.
// Author: Tom Gibb
// Date: 06-12-2026

// This program is the Goal Base Class for the EternalQuest project.
// It will define the properties and methods that will be inherited by the derived classes.
// The Goal class will also include a method to display the goal's information, which can be overridden by the derived classes to provide specific details about each type of goal.
// The Goal class will serve as the foundation for creating different types of goals in the EternalQuest project, allowing for code reuse and organization through inheritance.
// The Goal class will have properties for the name, description, and points associated with each goal. It will also have a method to display this information in a formatted manner.
// Derived classes can override this method to provide additional details or specific formatting as needed.
// The Goal class will be designed to be flexible and extensible, allowing for the creation of various types of goals such as SimpleGoal, EternalGoal, and ChecklistGoal, each with their own unique behaviors and properties while still maintaining a common structure through inheritance from the Goal base class.
// Properties:
// - name: A string representing the name of the goal.
// - description: A string providing a description of the goal.
// - points: A string representing the points associated with the goal.
// Methods:
// - DisplayGoalInfo(name,description,points): A virtual method that displays the goal's information in a formatted manner. This method can be overridden by derived classes to provide specific details about each type of goal.
// - RecordEvent() void : A virtual method that can be overridden by derived classes to record an event related to the goal, such as marking it as completed or updating its status.
//      This method can be used to track progress and manage the state of the goal within the EternalQuest project.
// - IsComplete() bool : A virtual method that can be overridden by derived classes to determine if the goal has been completed.
//      This method can return a boolean value indicating whether the goal has been achieved or not, allowing for conditional logic based on the completion status of the goal within the EternalQuest project.
// - GetDetailsString() string : A virtual method that can be overridden by derived classes to return a string containing the details of the goal.
//      This method can be used to provide a formatted string representation of the goal's details,
//      which can be useful for displaying information to the user or for debugging purposes within the EternalQuest project.
// - GetStringRepresentation() string : A virtual method that can be overridden by derived classes to return a string representation of the goal.
//      This method can be used to provide a concise string representation of the goal, which can be useful for displaying a summary of the goal's information or for logging purposes within the EternalQuest project.

using System;

class Goal(string name, string description, string points)
{
    protected string name = name;
    protected string description = description;
    protected string points = points;

    public virtual void RecordEvent()
    {
        // This method can be overridden by derived classes to record an event related to the goal.
    }
     public virtual bool IsComplete()
     {
          // This method can be overridden by derived classes to determine if the goal has been completed.
          return false;
     }
     public virtual string GetDetailsString()
     {
          // This method can be overridden by derived classes to return a string containing the details of the goal.
          return $"Goal: {name}, Description: {description}, Points: {points}";
     }
     public virtual string GetStringRepresentation()
     {
          // This method can be overridden by derived classes to return a string representation of the goal.
          return $"{name}:{description}:{points}";
     }
}
