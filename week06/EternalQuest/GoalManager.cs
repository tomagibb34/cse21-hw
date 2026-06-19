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
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

class GoalManager
{
    protected string Name;
    protected string Description;
    protected string Points;
    protected List<Goal> _myGoals = new List<Goal>();
    protected int Score = 0;
    private int _theChoice = 0;
    private string _myChoice = "";

    public void Start()
    {
        // This method can be called to start the goal management process, which may include displaying a menu or interface for interacting with the goals.
        // Menu will cover the range of all that should be done with the goal processes.
        // The following menu choices will be available
        // - 1 'Read Goal Information from a file called "GoalArchive.txt" or all user to specify new alternative filename.
        // - 2 'Write Goal Information to a file called "GoalArchive.txt" or all user to specify new alternative filename.
        // - 3 Display current goal information from list
        // - 4 Add goal information to list
        // - 5 Define Bonus score for desired goals
        // - 6 Show current score without bonus
        // - 7 Show current score combined with bonus
        // - 8 Add player or user information
        // - 9 Added goal and details as well as possible bonus
        // - 10 Define CheckList Goals and score
        // - 11 Define Eternal Goals and score and bonus
        // - 12 Define Simple Goals and score and bonus
        // - 13 To 'Exit'
        // make it all work together.


        while (_theChoice != 13)
        {
            Console.WriteLine("Menu: \b");
            Console.WriteLine("1 - Read Goal Information from a file");
            Console.WriteLine("2 - Write Goal Information to a file");
            Console.WriteLine("3 - Display current goal from a list");
            Console.WriteLine("4 - Add goal to list");
            Console.WriteLine("5 - Define Bonus score for desired goals");
            Console.WriteLine("6 - Show current score without bonus");
            Console.WriteLine("7 - Show current score combined with bonus");
            Console.WriteLine("8 - Add player or user information");
            Console.WriteLine("9 - Add goal and details as well as possible bonus to list");
            Console.WriteLine("10 - Define CheckList Goals and score");
            Console.WriteLine("11 - Define Eternal Goals and score and bonus");
            Console.WriteLine("12 - Define Simple Goals and score and bonus");
            Console.WriteLine("13 - Exit \b");

            Console.WriteLine("Please select an option from the menu:");

            // validate input: must be an integer 1-13 (13 = quit)
            while (true)
            {
                _myChoice = Console.ReadLine();

                if (!int.TryParse(_myChoice, out _theChoice))
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 13.");
                    continue;
                }
                if (_theChoice < 1 || _theChoice > 13)
                {
                    Console.WriteLine("Please enter a choice between 1 and 13.");
                    continue;
                }
                break;
            }
             switch (_theChoice)
            {
                case 1:
                    Console.WriteLine("You have chosen to load all current Goal information from a file. \b");
                    Console.WriteLine("Do you want to utilize the default name or enter your own name? Enter a name or blank for default");
                    _myChoice = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(_myChoice))
                    {
                        _myChoice = "GoalArchive.txt";
                    }
                    else
                    {
                        _myChoice = _myChoice.Trim();
                    }

                    Console.WriteLine($"Loading goals from: {_myChoice}");
                    LoadGoals(_myChoice);

                    break;
                case 2:
                    Console.WriteLine("You have chosen to write the current contents of the Goal List variable to a file. \b");
                    Console.WriteLine("Do you want to utilize the default name or enter your own name? Enter a name or blank for default.");
                    _myChoice = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(_myChoice))
                    {
                        _myChoice = "GoalArchive.txt";
                    }
                    else
                    {
                        _myChoice = _myChoice.Trim();
                    }

                    Console.WriteLine($"Writing goals to: {_myChoice}");
                    SaveGoals(_myChoice);
                    
                    break;
                case 3:
                        Console.WriteLine("You have chosen to iterate through the list of goals to select one that you want to take action on?");
                        Console.WriteLine("Is this correct? Enter Yes or No.");
                        _myChoice = Console.ReadLine();
                        try
                        {
                            if (string.IsNullOrWhiteSpace(_myChoice))
                            {
                                throw new ArgumentException("No response entered. Please enter Yes or No.");
                            }

                            _myChoice = _myChoice.Trim();

                            if (_myChoice.Equals("yes", StringComparison.CurrentCultureIgnoreCase))
                            {
                                Console.WriteLine("Proceeding to goal selection...");
                                ListGoalDetails();
                            }
                            else if (_myChoice.Equals("no", StringComparison.CurrentCultureIgnoreCase))
                            {
                                Console.WriteLine("Returning to the main menu.");
                            }
                            else
                            {
                                throw new ArgumentException("Invalid entry. Please enter Yes or No.");
                            }
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Unexpected error: {ex.Message}");
                        }

                    break;
                case 4:
                    RecordEvent();
                    break;
                case 5:
                    Console.WriteLine(GetDetailsString());
                    break;
                case 6:
                    Console.WriteLine(GetStringRepresentation());
                    break;
                case 13:
                    Console.WriteLine("You have chosen to exit the program. Good bye!!!!!");
                    return;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }

    public string GetPlayerInfo()
    {
        // This method returns a string containing the player's current score and other relevant information related to the goals, which can be used for displaying information to the user or for debugging purposes within the EternalQuest project.
        // Get player info and return as string
        Console.WriteLine("Getting player name and other info");

        Console.WriteLine("Player Score: " + Score);

        return $"Player Score: {Score}";
    }

     public static void DisplayPlayerInfo()
    {
        // This method displays the player's current score and other relevant information related to the goals.
    }

    public static void ListGoalNames()
    {
        // This method lists the names of all the goals currently managed by the GoalManager class, providing an overview of the available goals.
    }

    public string GetDetailsString()
    {
        // Build and return a combined details string by delegating to each Goal's GetDetailsString method.
        if (_myGoals == null || _myGoals.Count == 0)
        {
            return "No goals available.";
        }

        var sb = new System.Text.StringBuilder();
        for (int i = 0; i < _myGoals.Count; i++)
        {
            var goal = _myGoals[i];
            if (goal == null)
            {
                sb.AppendLine($"{i + 1}. <Empty goal entry>");
                continue;
            }

            // Delegate to the Goal class's GetDetailsString method
            try
            {
                sb.AppendLine($"{i + 1}. {goal.GetDetailsString()}");
            }
            catch (System.Exception ex)
            {
                sb.AppendLine($"{i + 1}. <Error getting details: {ex.Message}>");
            }
        }

        return sb.ToString();
    }

    public string GetStringRepresentation()
    {
        // Build and return a combined string representation by delegating to each Goal's GetStringRepresentation method.
        if (_myGoals == null || _myGoals.Count == 0)
        {
            return "No goals available.";
        }

        var sb = new System.Text.StringBuilder();
        for (int i = 0; i < _myGoals.Count; i++)
        {
            var goal = _myGoals[i];
            if (goal == null)
            {
                sb.AppendLine($"{i + 1}. <Empty goal entry>");
                continue;
            }

            try
            {
                sb.AppendLine($"{i + 1}. {goal.GetStringRepresentation()}");
            }
            catch (System.Exception ex)
            {
                sb.AppendLine($"{i + 1}. <Error getting representation: {ex.Message}>");
            }
        }

        return sb.ToString();
    }

    public void ListGoalDetails()
    {
        // This method lists the details of all the goals currently managed by the GoalManager class, providing more in-depth information about each goal.

        // Iterate through the list of goals and display each with an index number so the user can select one for action.
        if (_myGoals == null || _myGoals.Count == 0)
        {
            Console.WriteLine("No goals available to display.");
            return;
        }

        Console.WriteLine("Goal Details:");
        for (int i = 0; i < _myGoals.Count; i++)
        {
            var goal = _myGoals[i];
            if (goal == null)
            {
                Console.WriteLine($"{i + 1}. <Empty goal entry>");
                continue;
            }

            Console.WriteLine($"{i + 1}. {goal}");
        }
    }

    public static void CreateGoal()
    {
        // This method allows the user to create a new goal by providing necessary information such as name, description, and points. This method can be used to add new goals to the goals list.
    }

    public void RecordEvent()
    {
        // This method allows the user to record an event related to a specific goal, such as marking it as completed or updating its status. This method can be used to track progress and manage the state of the goals within the GoalManager class.
        Console.WriteLine("Allow the user to enter or record a goal. They will be able to designate it as a 'Simple', 'Eternal', or 'List' type goal as part of their entry.");
        Console.WriteLine("They will also be able to assign an individual score for each goal as well as a bonus score if desired and the points to be associated with each.");
        Console.WriteLine("They will also be able to enter a completion flag to indicate they have completed it or the number of times they have to complete it to be successful. \b");

        // Prompt for goal type and keep asking until a valid goal is created and stored.
        bool goalCreated = false;
        while (!goalCreated)
        {
            Console.WriteLine("\nSelect goal type:");
            Console.WriteLine("1 - Simple Goal");
            Console.WriteLine("2 - Eternal Goal");
            Console.WriteLine("3 - List Goal");
            Console.Write("Enter choice (1-3): ");

            string goalTypeChoice = Console.ReadLine();
            string goalTypeName = GetGoalTypeName(goalTypeChoice);
            if (goalTypeName == "Unknown Type")
            {
                Console.WriteLine("Invalid goal type selected. Please try again.");
                continue;
            }

            // Prompt for description
            Console.Write("Enter goal description: ");
            string description = Console.ReadLine();

            // Prompt for points value
            Console.Write("Enter points value for this goal: ");
            string pointsInput = Console.ReadLine();
            if (!int.TryParse(pointsInput, out int points) || points < 0)
            {
                Console.WriteLine("Invalid points value. Please enter a positive number.");
                continue;
            }

            // Prompt for bonus points
            Console.Write("Enter bonus points (if any, or 0 for none): ");
            string bonusInput = Console.ReadLine();
            if (!int.TryParse(bonusInput, out int bonus) || bonus < 0)
            {
                Console.WriteLine("Invalid bonus value. Please enter a positive number.");
                continue;
            }

            var pointsRepresentation = bonus > 0
                ? $"{points} (+{bonus} bonus)"
                : points.ToString();

            var goalDescription = bonus > 0
                ? $"{description} [Bonus: {bonus}]"
                : description;

            var newGoal = new Goal(goalTypeName, goalDescription, pointsRepresentation);
            _myGoals.Add(newGoal);

            Console.WriteLine($"\nGoal created and added to the list:");
            Console.WriteLine($"Type: {goalTypeName}");
            Console.WriteLine($"Description: {description}");
            Console.WriteLine($"Points: {points}");
            Console.WriteLine($"Bonus Points: {bonus}");
            Console.WriteLine($"Total goals in list: {_myGoals.Count}\n");

            goalCreated = true;
        }
    }

    private static string GetGoalTypeName(string choice)
    {
        return choice switch
        {
            "1" => "Simple Goal",
            "2" => "Eternal Goal",
            "3" => "List Goal",
            _ => "Unknown Type"
        };
    }

    public void SaveGoals(string filename)
    {
        // This method takes a filename as a parameter and saves the current list of goals to a file. This method can be used to persist the goal data across sessions, allowing the user to save their progress and load it later.
        if (string.IsNullOrWhiteSpace(filename))
        {
            Console.WriteLine("No filename specified for loading goals.");
            return;
        }

        // Prepare lines to write from the internal goals list. Create or overwrite the target file.
        try
        {
            var lines = new List<string>();

            if (_myGoals.Count == 0)
            {
                Console.WriteLine("No goals to save. Creating/overwriting file with no contents.");
            }
            else
            {
                foreach (var g in _myGoals)
                {
                    // Use the Goal's string representation from Goal.GetStringRepresentation; ensure non-null
                    lines.Add(g?.GetStringRepresentation() ?? string.Empty);
                    Console.WriteLine($"Saved {_myGoals.Count} goal(s) to '{filename}'.");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Failed to save goals to '{filename}': {ex.Message}");
        }
    }

    public void LoadGoals(string filename)
    {
        // This method takes a filename as a parameter and loads a list of goals from a file. This method can be used to restore previously saved goal data, allowing the user to continue managing their goals from where they left off.

        if (string.IsNullOrWhiteSpace(filename))
        {
            Console.WriteLine("No filename specified for loading goals.");
            return;
        }

        if (!File.Exists(filename))
        {
            Console.WriteLine($"Goal file not found: {filename}");
            return;
        }

        var _fileLines = new List<string>(File.ReadAllLines(filename));

        _myGoals.Clear();

        foreach (var line in _fileLines)
        {
            if (string.IsNullOrWhiteSpace(line))
            {
                continue;
            }

            // Raw file data has been read into a list variable.
            // If a Goal parser or factory is available, convert each line into a Goal object here.
            Console.WriteLine($"Loaded goal line: {line}");
        }

        Console.WriteLine($"Loaded {_fileLines.Count} lines from '{filename}'.");
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

        return Score;
    }
}
