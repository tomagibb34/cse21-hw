// Journal Project
// This is a simple journal program that allows the user to write, display, load, and save journal entries.
// Author: Thomas A Gibb
// Date: 05/11/2026
// Class: CSE 210 - Introduction to Programming

// This is the main program for the Journal project. It will display a menu to the user and allow them to select one of the following choices:
// 1. Write - This will allow the user to write a new journal entry.
// 2. Display - This will display all of the journal entries that have been written.
// 3. Load - This will allow the user to load a journal from a file.
// 4. Save - This will allow the user to save their journal to a file.
// 5. Quit - This will allow the user to quit the program.

// Define the system inputs and outputs, as well as the necessary libraries for file handling and collections.
// The System library is used for basic input and output operations, such as reading from the console and writing to the console.
// The System.IO library is used for file handling operations, such as reading from and writing to files
// The System.Collections.Generic library is used for collections, such as lists and dictionaries, which will be used to store the journal entries in memory.
// The program will use a list to store the journal entries in memory, and will use file handling operations to save and load the journal entries from a file.
// The program will also use a simple menu system to allow the user to select one of the choices listed above.
// The program will continue to run until the user selects the "Quit" option.

using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        Console.WriteLine("");
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        string choice = Console.ReadLine();

        Console.WriteLine($"You selected: {choice}");
        // The program will continue to run until the user selects the "Quit" option.
        while (choice != "5")
        {
            if (choice == "1")
            {
                Console.WriteLine("You selected: Write");
                // Code to write a new journal entry will go here.
            }
            else if (choice == "2")
            {
                Console.WriteLine("You selected: Display");
                // Code to display all of the journal entries will go here.
            }
            else if (choice == "3")
            {
                Console.WriteLine("You selected: Load");
                // Code to load a journal from a file will go here.
            }
            else if (choice == "4")
            {
                Console.WriteLine("You selected: Save");
                // Code to save the journal to a file will go here.
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select one of the following choices:");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Quit");
            }
            choice = Console.ReadLine();

            
        }




    }
}