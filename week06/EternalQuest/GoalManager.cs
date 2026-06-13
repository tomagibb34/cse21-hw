// CSE 210 - Introduction to Programming
// Exercise 1 - Practice with Program to utilize EternalQuest project with this being the GoalManager Class and test functionality of base class and inheritance and overriding methods.
// Author: Tom Gibb
// Date: 06-12-2026

// This program is the GoalManager Class for the EternalQuest project.
// The GoalManager class will be responsible for managing a collection of goals, allowing for adding, removing, and displaying goals.
// It will also provide functionality to save and load goals from a file, enabling persistence of goal data across sessions.
// The GoalManager class will utilize the Goal base class and its derived classes to create and manage different types of goals within the EternalQuest project.
// This class will serve as a central hub for goal management, providing an organized structure for handling various goal-related operations in the project.
// The GoalManager class will include methods for adding new goals, removing existing goals, displaying all goals, and saving/loading goals to/from a file.
// It will also maintain a list of goals and provide functionality to interact with this list effectively.

// Properties:
// - goals: A list of Goal objects representing the collection of goals managed by the GoalManager class.
// - score: An integer representing the total score accumulated from completed goals.
// Methods:
// - GoalManager(): A constructor that initializes the goals list and sets the score to zero.
// - Start(): A method that can be called to start the goal management process, which may include displaying a menu or interface for interacting with the goals.
// - DisplayPlayerInfo(): A method that displays the player's current score and other relevant information related to the goals.
// - GetPlayerInfo(): A method that returns a string containing the player's current score and other relevant information related to the goals, which can be used for displaying information to the user or for debugging purposes within the EternalQuest project.
// - ListGoalNames(): A method that lists the names of all the goals currently managed by the GoalManager class, providing an overview of the available goals.
// - ListGoalDetails(): A method that lists the details of all the goals currently managed by the GoalManager class, providing more in-depth information about each goal.
// - CreateGoal(): A method that allows the user to create a new goal by providing necessary information such as name, description, and points. This method can be used to add new goals to the goals list.
// - RecordEvent(): A method that allows the user to record an event related to a specific goal, such as marking it as completed or updating its status. This method can be used to track progress and manage the state of the goals within the GoalManager class.
// - SaveGoals(string filename): A method that takes a filename as a parameter and saves the current list of goals to a file. This method can be used to persist the goal data across sessions, allowing the user to save their progress and load it later.
// - LoadGoals(string filename): A method that takes a filename as a parameter and loads a list of goals from a file. This method can be used to restore previously saved goal data, allowing the user to continue managing their goals from where they left off.
// - AddGoal(Goal goal): A method that takes a Goal object as a parameter and adds it to the goals list.
// - RemoveGoal(Goal goal): A method that takes a Goal object as a parameter and removes it from the goals list.
// - GetTotalScore(): A method that calculates and returns the total score accumulated from completed goals, providing an overview of the player's progress and achievements within the GoalManager class.

using System;
using System.Collections.Generic;

class GoalManager
{
    private readonly List<Goal> goals;
    private readonly int score;

    public GoalManager()
    {
        goals = new List<Goal>();
        score = 0;
    }

    public static void Start()
    {
        // This method can be called to start the goal management process, which may include displaying a menu or interface for interacting with the goals.
    }

    public static string GetPlayerInfo()
    {
        // This method returns a string containing the player's current score and other relevant information related to the goals, which can be used for displaying information to the user or for debugging purposes within the EternalQuest project.
        // Get player info and return as string
        Console.WriteLine("Getting player name and other info");

        var manager = new GoalManager();
        Console.WriteLine("Player Score: " + manager.score);

        return $"Player Score: {manager.score}";
    }

     public static void DisplayPlayerInfo()
    {
        // This method displays the player's current score and other relevant information related to the goals.
    }

    public static void ListGoalNames()
    {
        // This method lists the names of all the goals currently managed by the GoalManager class, providing an overview of the available goals.
    }

    public static void ListGoalDetails()
    {
        // This method lists the details of all the goals currently managed by the GoalManager class, providing more in-depth information about each goal.
    }

    public static void CreateGoal()
    {
        // This method allows the user to create a new goal by providing necessary information such as name, description, and points. This method can be used to add new goals to the goals list.
    }

    public static void RecordEvent()
    {
        // This method allows the user to record an event related to a specific goal, such as marking it as completed or updating its status. This method can be used to track progress and manage the state of the goals within the GoalManager class.
    }

    public static void SaveGoals(string filename)
    {
        // This method takes a filename as a parameter and saves the current list of goals to a file. This method can be used to persist the goal data across sessions, allowing the user to save their progress and load it later.
    }

    public static void LoadGoals(string filename)
    {
        // This method takes a filename as a parameter and loads a list of goals from a file. This method can be used to restore previously saved goal data, allowing the user to continue managing their goals from where they left off.
    }

    public static void AddGoal(Goal goal)
    {
        // This method takes a Goal object as a parameter and adds it to the goals list.
    }

    public static void RemoveGoal(Goal goal)
    {
        // This method takes a Goal object as a parameter and removes it from the goals list.
    }

    public int GetTotalScore()
    {
        // This method calculates and returns the total score accumulated from completed goals, providing an overview of
        // the player's progress and achievements within the GoalManager class.

        return score;
    }
}
