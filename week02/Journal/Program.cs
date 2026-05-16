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

using System;  // This library is used for basic input and output operations, such as reading from the console and writing to the console.
using System.IO;  // This library is used for file handling operations, such as reading from and writing to files.
using System.Collections.Generic;  // This library is used for collections, such as lists and dictionaries, which will be used to store the journal entries in memory.

// The following classes will be used to handle the different operations of the program, such as reading from a file, writing to a file, displaying the journal entries, and reading prompts from a file.

using static WriteJournalFile;  // This class will be used to handle the writing of journal entries to a file.
using static ReadJournalFile;  // This class will be used to handle the reading of journal entries from a file.
using static DisplayJournal;  // This class will be used to handle the displaying of journal entries to the console.
using static ReadPromptFile;  // This class will be used to handle the reading of prompts from a file, which will be used to generate random prompts for the user to write about in their journal entries.

 // This is the main class of the program, which will contain the main method and any other methods that are needed for the program to function.
class Program
{
     private static List<string> journalEntries;

     static void Main(string[] args)  // This is the main method of the program, which will be executed when the program is run.
    {
        Console.WriteLine("Hello World! This is the Journal Project.");  // This will display a welcome message to the user when the program is run.
        Console.WriteLine("");  // This will add a blank line to the console for better readability.

        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write Journal Entry");  // This will allow the user to write a new journal entry.
        Console.WriteLine("2. Display Journal Entries");  // This will display all of the journal entries that have been written.
        Console.WriteLine("3. Load Journal");  // This will allow the user to load a journal from a file.
        Console.WriteLine("4. Save Journal");  // This will allow the user to save their journal to a file.
        Console.WriteLine("5. Quit");  // This will allow the user to quit the program. 
        string choice = Console.ReadLine();

        Console.WriteLine($"You selected: {choice}");  // This will display the user's choice back to them for confirmation.

        // The program will continue to run until the user selects the "Quit" option.

        while (choice != "5")  // This will continue to run the program until the user selects the "Quit" option.
        {
            if (choice == "1")  // This will allow the user to write a new journal entry.
            {
                // This will display a message to the user confirming that they have selected the "Write" option.
                Console.WriteLine("You selected: Write journal entry");

                // Code to write a new journal entry will go here.
                // Input the Prompt for the journal entry, which will be randomly selected from a list of prompts that are read from a file using the ReadPromptFile class.
                // The ReadPromptFile class will have a method called ReadPromptsFromFile, which will handle the reading of prompts from a file. This method will read the prompts from the specified file and store them in a list in memory, which can then be used to randomly select a prompt for the user to write about in their journal entry.
                // This will create a new instance of the ReadPromptFile class, which will be used to handle the reading of prompts from a file.

                ReadPromptFile readPromptFile = new();

                // Define the file name for the ReadPromptFile class, which will be used to specify the file that the prompts will be read from.
                readPromptFile._fileName = "prompts.txt";  // This will set the file name for the ReadPromptFile class to "prompts.txt". 
                
                // This will call the ReadPromptsFromFile method of the ReadPromptFile class, which will handle the reading of prompts from a file. The ReadPromptsFromFile method will read the prompts from the specified file and store them in a list in memory, which can then be used to randomly select a prompt for the user to write about in their journal entry.
                List<string> _prompts = readPromptFile.ReadPromptsFromFile(readPromptFile._fileName);

                // This will check if the list of prompts is empty, and if it is, it will display a message to the user and return to the main menu.
                if (_prompts.Count == 0)
                {
                    Console.WriteLine("No prompts found. Please add prompts to the prompts.txt file and try again.");
                    continue;  // This will return to the main menu if no prompts are found.
                }

                // Allow the user to write as many journal entries as they want based on the selected prompt.
                string _journalEntry = "test";  // This will be used to store the user's journal entry input.

                while (_journalEntry != "")  // This will allow the user to write as many journal entries as they want based on the selected prompt. The user can exit this loop by entering an empty string (pressing Enter without typing anything).
                {
                    // Add the date and time to the first journal entry by testing for the value of the _journalEntry variable. If the value is "test", then this will be the first journal entry, and the program will add the date and time to the entry before it is added to the list of journal entries in memory.
                    if (_journalEntry == "test")
                    {
                        _journalEntry = $"{DateTime.Now}: ";  // This will add the current date and time to the journal entry, followed by a space for the user to start typing their entry.
                    }
                    // This will randomly select a prompt from the list of prompts that were read from the file, and it will display the selected prompt to the user for them to write about in their journal entry.
                    Random random = new Random();

                    int _promptIndex = random.Next(_prompts.Count);
                    string _selectedPrompt = _prompts[_promptIndex];

                    Console.WriteLine($"Your prompt is: {_selectedPrompt}");

                    // This will prompt the user to enter their journal entry, and it will read the user's input for the journal entry.
                    Console.WriteLine("Please enter your journal entry: To finish writing, press Enter on an empty line.");
                    
                    _journalEntry = Console.ReadLine();
                    
                    // This will add the user's journal entry to the list of journal entries in memory, which can then be displayed to the user or saved to a file when the user selects the corresponding options.
                    
                    if (journalEntries == null)
                    {
                        journalEntries = new List<string>();
                    }
                    journalEntries.Add(_journalEntry);

                }


                // This will call the WriteEntry method of the WriteJournalFile class, which will handle the writing of a new journal entry to a file.
                // The WriteEntry method will prompt the user for the journal entry, and then write it to a file using file handling operations.
                // This will create a new instance of the WriteJournalFile class, which will be used
                // to handle the writing of journal entries to a file. The WriteJournalFile class will have a method called WriteEntry, which will handle the writing of a new journal entry to a file. This method will prompt the user for the journal entry, and then write it to a file using file handling operations.
                WriteJournalFile writeJournalFile = new();
                writeJournalFile._fileName = "journal.txt";  // This will set the file name for the WriteJournalFile class to "journal.txt".
                writeJournalFile.WriteToFile(journalEntries);  // This will call the WriteEntry method of the WriteJournalFile class, which will handle the writing of a new journal entry to a file. The WriteEntry method will prompt the user for the journal entry, and then write it to a file using file handling operations.
            }
            else if (choice == "2")  // This will display all of the journal entries that have been written.
            {
                Console.WriteLine("You selected: Display Journal Entries");  // This will display a message to the user confirming that they have selected the "Display" option.
                // Code to display all of the journal entries will go here.
                // This will create a new instance of the DisplayJournal class, which will be used to handle the displaying of journal entries to the console.
                
                DisplayJournal displayJournal = new();

                // This will call the DisplayEntries method of the DisplayJournal class, which will handle the displaying of journal entries to the console. The DisplayEntries method will take a list of journal entries as a parameter, and it will display each entry to the console in a readable format.
                
                displayJournal.DisplayEntries(journalEntries);
                
            }
            else if (choice == "3")  // This will allow the user to load a journal from a file.
            {
                Console.WriteLine("You selected: Load Journal");  // This will display a message to the user confirming that they have selected the "Load" option.
                // Code to load a journal from a file will go here.
                // This will create a new instance of the ReadJournalFile class, which will be used to handle the reading of journal entries from a file.

                ReadJournalFile readJournalFile = new();
                
                // This will prompt the user to enter the file name for the journal entries they want to load, or to press Enter to use the default file name.
                
                //Console.WriteLine("Please enter the file name for the journal entries you want to load (or press Enter to use the default file name 'journal.txt'):");

                //string fileName = Console.ReadLine();  // This will read the user's input for the file name.
                //if (string.IsNullOrEmpty(fileName))  // This will check if the user entered a file name or if they pressed Enter to use the default file name.
                //{
                
                readJournalFile._fileName = "journal.txt";  // If the user pressed Enter, this will set the file name for the ReadJournalFile class to "journal.txt".
                
                //}
                //else
                //{
                //    readJournalFile._fileName = fileName;  // If the user entered a file name, this will set the file name for the ReadJournalFile class to the user's input.
                //}
                // The file name can be changed to whatever the user prefers, or it can be set to a default file name if the user does not provide one.
                // The ReadJournalFile class will have a method called ReadFromFile, which will handle the reading of journal entries from a file.
                // This method will read the journal entries from the specified file and store them in a list in memory, which can then be displayed to the user or used for other operations.
                // This will call the ReadFromFile method of the ReadJournalFile class, which will handle the reading of journal entries from a file.
                // The ReadFromFile method will read the journal entries from the specified file and store them in a list in memory, which can then be displayed to the user or used for other operations.

                // This will call the ReadFromFile method of the ReadJournalFile class, which will read the journal entries from the specified file and store
                // them in a list in memory. The list of journal entries will then be stored in the journalEntries variable,
                // which can be used for other operations such as displaying the entries to the user or saving them to a file.

                List<string> journalEntries = readJournalFile.ReadFromFile(readJournalFile._fileName);
            }
            else if (choice == "4")  // This will allow the user to save their journal to a file.
            {
                Console.WriteLine("You selected: Save Journal");
                
                // This will display a message to the user confirming that they have selected the "Save" option.
                // Code to save the journal to a file will go here.
                // This will create a new instance of the WriteJournalFile class, which will be used to handle the writing of journal entries to a file.

                WriteJournalFile writeJournalFile = new();
                
                // Set the file name for the WriteJournalFile class, which will be used to specify the file that the journal entries will be written to.
                // This can be done by prompting the user for a file name, or by using a default file name.
                
                // This will prompt the user to enter a file name for their journal entries, or to press Enter to use the default file name.
                Console.WriteLine("Please enter the file name for your journal entries (or press Enter to use the default file name 'journal.txt'):");

                string fileName = Console.ReadLine();  // This will read the user's input for the file name.

                if (string.IsNullOrEmpty(fileName))  // This will check if the user entered a file name or if they pressed Enter to use the default file name.
                {
                    writeJournalFile._fileName = "journal.txt";  // If the user pressed Enter, this will set the file name for the WriteJournalFile class to "journal.txt".
                }
                else
                {
                    writeJournalFile._fileName = fileName;  // If the user entered a file name, this will set the file name for the WriteJournalFile class to the user's input.
                }   

                // The file name can be changed to whatever the user prefers, or it can be set to a default file name if the user does not provide one.
                
                // The WriteJournalFile class will have a method called WriteEntry, which will handle the writing of a new journal entry to a file. This method will prompt the user for the journal entry, and then write it to a file using file handling operations.
                // This will call the WriteEntry method of the WriteJournalFile class, which will handle the writing of a new journal entry to a file. 

                writeJournalFile.WriteToFile(journalEntries);

            }
            else  //
            {
                Console.WriteLine("Invalid choice. Please select one of the following choices:");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Quit");
            }
            choice = Console.ReadLine();  // This will read the user's choice again after they have made a selection and the program has executed the corresponding code for that selection.

            
        }




    }
}