// CSE 210 - Introduction to Programming
// Exercise 1 - Practice with Scripture Memorization
// Author: Tom Gibb
// Date: 05-19-2026

// This is a complex program that will be used to test the functionality of the Scripture class.
// The program will create a new instance of the Scripture class and call the DisplayScripture method to display the scripture to the user.
// The program will obtain the scripture reference from the user and then find that scripture reference in the scriptures.txt file.
// It will then store the scripture reference and text in separate strings within the Scripture class.
// This will allow the user to hide a random word in the scripture each time they type "hide" when prompted to hide a word.

// The program will then prompt the user to hide a word in the scripture by typing "hide" when prompted to hide a word.
// The program will selectively store the scripture reference and text in separate strings within the ScriptureMemorizer class.
// This will allow the user to hide a random word in the scripture each time they type "hide" when prompted to hide a word.
// The program will allow handle a scripture with multiple verses by storing the scripture reference and text in separate strings within the ScriptureMemorizer class. This will allow the user to hide a random word in the scripture each time they type "hide" when prompted to hide a word, regardless of how many verses are in the scripture.

// The program will then call the HideRandomWord method to hide a random word in the scripture and call the DisplayScripture method again to display the updated scripture to the user.
// The program will continue to call the HideRandomWord method and the DisplayScripture method until all words in the scripture are hidden.
// The program will also allow the user to exit the program by typing "quit" when prompted to hide a word.
// The program will also allow the user to reset the scripture by typing "reset" when prompted to hide a word.
// The program will also allow the user to display the original scripture by typing "original" when prompted to hide a word.
// The program will also allow the user to display the current scripture by typing "current" when prompted to hide a word.
// The program will also allow the user to display the number of words that are currently hidden by typing "hidden" when prompted to hide a word.
// The program will also allow the user to display the number of words that are currently visible by typing "visible" when prompted to hide a word.
// The program will also allow the user to display the percentage of words that are currently hidden by typing "percentage" when prompted to hide a word.
// The program will also allow the user to display the percentage of words that are currently visible by typing "percentage visible" when prompted to hide a word.
// The program will also allow the user to display the percentage of words that are currently hidden and visible by typing "percentage all" when prompted to hide a word.
// The program will also allow the user to display the original scripture, current scripture, number of hidden words, number of visible words, percentage of hidden words, percentage of visible words, and percentage of all words by typing "display" when prompted to hide a word.

// The program will allow the user to input a new scripture by typing "new" when prompted to hide a word.
// The program will also allow the user to input a new scripture by typing "new" when prompted to hide a word.
// The program will then prompt the user to enter the reference and the text of the scripture.
// The program will then create a new instance of the Scripture class with the new scripture and call the DisplayScripture method to display the new scripture to the user.
// The program will also allow the user to input a new scripture by typing "new" when prompted to hide a word. The program will then prompt the user to enter the reference and the text of the scripture. The program will then create a new instance of the ScriptureMemorizer class with the new scripture and call the DisplayScripture method to display the new scripture to the user.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// The Program class contains the Main method, which is the entry point of the application.
// It is responsible for creating an instance of the Scripture class and calling the DisplayScripture method to display the scripture to the user.
// The Program class also handles user input and calls the appropriate methods in the Scripture class based on the user's commands.
// The Program class does not include items or behaviors that do not pertain to it. It is focused on managing the flow of the application and interacting with the user.

// The Program class will also handle the logic for allowing the user to input a new scripture and display it to the user. It will prompt the user to enter the reference and text of the new scripture, create a new instance of the Scripture class with the new scripture, and call the DisplayScripture method to display the new scripture to the user.    
// The Program class will also handle the logic for allowing the user to input a new scripture and display it to the user. It will prompt the user to enter the reference and text of the new scripture, create a new instance of the ScriptureMemorizer class with the new scripture, and call the DisplayScripture method to display the new scripture to the user.
// The Program class will also handle the logic for allowing the user to input a new scripture and display it to the user. It will prompt the user to enter the reference and text of the new scripture, create a new instance of the ScriptureMemorizer class with the new scripture, and call the DisplayScripture method to display the new scripture to the user. This will allow the user to hide a random word in the scripture each time they type "hide" when prompted to hide a word, regardless of how many verses are in the scripture.
// The Program will handle invalid book names inputs by prompting the user to enter a valid book name until they do so. This will ensure that the program can find the scripture reference in the lds-scriptures.txt file and store the scripture reference and text in separate strings within the Scripture class. The Program will also handle invalid book names inputs by prompting the user to enter a valid book name until they do so. This will ensure that the program can find the scripture reference in the scriptures.txt file and store the scripture reference and text in separate strings within the ScriptureMemorizer class. This will allow the user to hide a random word in the scripture each time they type "hide" when prompted to hide a word, regardless of how many verses are in the scripture.
// The Program will handle the logic to allow the user to re-enter the chapter and verse(s) if they input an invalid chapter or verse(s). This will ensure that the program can find the scripture reference in the lds-scriptures.txt file and store the scripture reference and text in separate strings within the Scripture class. The Program will also handle the logic to allow the user to re-enter the chapter and verse(s) if they input an invalid chapter or verse(s). This will ensure that the program can find the scripture reference in the scriptures.txt file and store the scripture reference and text in separate strings within the ScriptureMemorizer class. This will allow the user to hide a random word in the scripture each time they type "hide" when prompted to hide a word, regardless of how many verses are in the scripture.

using static Reference;
using static Word;
using static Scripture;


// Removed incorrect using directives for types (Reference, Word, Scripture).
// Types are referenced directly in this file.


partial class Program
{
     // Field to store an array of Scripture objects, which will be used to manage multiple scriptures in the program.
     // This will allow the user to input a new scripture and have it stored in the array of Scripture objects, and to call the DisplayScripture method for each scripture in the array when prompted to display the scriptures.
     static void Main(string[] args)
     {
          Console.WriteLine("Hello World! This is the Scripture Project.");

          // Initialize the Reference class with the user's input for the book, chapter, and verse(s) of the scripture reference. This will allow the program to store the scripture reference and text in separate strings within the Scripture class.            // Initialize the Reference class with the user's input for the book, chapter, and verse(s) of the scripture reference. This will allow the program to store the scripture reference and text in separate strings within the ScriptureMemorizer class.
          // This will allow the user to hide a random word in the scripture each time they type "hide" when prompted to hide a word, regardless of how many verses are in the scripture.

          Reference myReference = new Reference(Console.ReadLine(), 0, 0);

          // Start book query loop to obtain the book from the user and store it in a string variable. This will allow the program to store the scripture reference and text in separate strings within the Scripture class.            // Start book query loop to obtain the book from the user and store it in a string variable. This will allow the program to store the scripture reference and text in separate strings within the ScriptureMemorizer class.
          // This will allow the user to hide a random word in the scripture each time they type "hide" when prompted to hide a word, regardless of how many verses are in the scripture.
          // The loop will continue until the user inputs a valid book from the scriptures.txt file. This will ensure that the program can find the scripture reference in the scriptures.txt file and store the scripture reference and text in separate strings within the Scripture class.
          // The loop will also allow the user to input a new book if they input an invalid book, which will allow the program to find the scripture reference in the scriptures.txt file and store the scripture reference and text in separate strings within the Scripture class.
          // The loop will also allow the user to input a new book if they input an invalid book, which will allow the program to find the scripture reference in the scriptures.txt file and store the scripture reference and text in separate strings within the ScriptureMemorizer class. This will allow the user to hide a random word in the scripture each time they type "hide" when prompted to hide a word, regardless of how many verses are in the scripture.

          while (true)
          {
               Console.WriteLine("Do you want to play again, 'yes' or 'quit' to exit:");
               string input = Console.ReadLine();
               if (input.Equals("quit", StringComparison.CurrentCultureIgnoreCase))
               {
                    return;
               }
               else if (input.Equals("yes", StringComparison.CurrentCultureIgnoreCase))
               {
                    while (true)
                    {
                         Console.WriteLine("Please enter the book of the scripture reference:");
                         string _myBook = myReference.GetBook();
                         if (myReference.IsValidBook(_myBook))
                         {
                              break;
                         }
                         else
                         {
                              Console.WriteLine("Invalid book. Please try again.");
                         }
                    }


                    int _myChapter = myReference.GetChapter();

                    (int _1stVerse, int _lastVerse) = myReference.GetVerse();

                    // Initialize the Scripture class with the scripture reference and text obtained from the scriptures.txt file. This will allow the program to store the scripture reference and text in separate strings within the Scripture class.            // Initialize the Scripture class with the scripture reference and text obtained from the scriptures.txt file. This will allow the program to store the scripture reference and text in separate strings within the ScriptureMemorizer class.
                    // This will allow the user to hide a random word in the scripture each time they type "hide" when prompted to hide a word, regardless of how many verses are in the scripture.
                    // Initialize the GetScripture method to obtain the scripture text from the lds-scriptures.txt file based on the user's input for the scripture reference.
                    // This will allow the program to store the scripture reference and text in separate strings within the Scripture class.


                    Scripture myScripture;

                    // GetDisplayText may return a string array; join into a single string for the Scripture constructor

                    string displayText = myReference.GetDisplayText() is string[] parts
                        ? string.Join(" ", parts)
                        : myReference.GetDisplayText()?.ToString() ?? string.Empty;

                    if (_lastVerse == 0)
                    {
                        myScripture = new Scripture(displayText, "This is the scripture text for a single verse.");
                    }
                    else
                    {
                        myScripture = new Scripture(displayText, "This is the scripture text for multiple verses.");
                    }

                    // Call the DisplayScripture method.

                    myScripture.DisplayScripture();

                    // Start the hide word loop to allow the user to hide a random word in the scripture each time they type "hide" when prompted to hide a word. This will allow the user to hide a random word in the scripture each time they type "hide" when prompted to hide a word, regardless of how many verses are in the scripture.
                    // The loop will continue until all words in the scripture are hidden. This will allow the user to continue hiding words until they have hidden all the words in the scripture, which will help them to memorize the scripture.
                    // The loop will also allow the user to exit the program by typing "quit" when prompted to hide a word. This will allow the user to exit the program at any time if they choose to do so.
                    // The loop will also allow the user to reset the scripture by typing "reset" when prompted to hide a word. This will allow the user to reset the scripture to its original state if they want to start over with hiding words.
                    // The loop will also allow the user to display the original scripture by typing "original" when prompted to hide a word. This will allow the user to see the original scripture if they want to compare it to the current state of the scripture with hidden words.
                    // The loop will also allow the user to display the current scripture by typing "current" when prompted to hide a word. This will allow the user to see the current state of the scripture with hidden words if they want to compare it to the original scripture.
                    // The loop will also allow the user to display the number of words that are currently hidden by typing "hidden" when prompted to hide a word. This will allow the user to see how many words they have hidden in the scripture.
                    // The loop will also allow the user to display the number of words that are currently visible by typing "visible" when prompted to hide a word. This will allow the user to see how many words are still visible in the scripture.
                    // The loop will also allow the user to display the percentage of words that are currently hidden by typing "percentage" when prompted to hide a word. This will allow the user to see the percentage of words that they have hidden in the scripture.
                    // The loop will also allow the user to display the percentage of words that are currently visible by typing "percentage visible" when prompted to hide a word. This will allow the user to see the percentage of words that are still visible in the scripture.
                    // The loop will also allow the user to display the percentage of words that are currently hidden and visible by typing "percentage all" when prompted to hide a word. This will allow the user to see the percentage of words that they have hidden and the percentage of words that are still visible in the scripture.
                    // The loop will also allow the user to display the original scripture, current scripture, number of hidden words, number of visible words, percentage of hidden words, percentage of visible words, and percentage of all words by typing "display" when prompted to hide a word. This will allow the user to see all the information about the scripture in one place if they want to see it.

                    while (true)
                    {
                        // Define all the links to the Word class methods to allow the user to hide and show words, get the text of the words, and get the hidden status of the words. This will allow the user to manipulate the visibility of the words in the scripture and to see the text of the words and their hidden status when they want to.  

                        Console.WriteLine("\n", "\n");
                       
                        Console.WriteLine("Type 'hide' to hide a word, 'quit' to exit, 'reset' to reset the scripture, 'original' to display the original scripture, 'current' to display the current scripture, 'hidden' to display the number of hidden words,");
                        Console.WriteLine("Type 'visible' to display the number of visible words, 'percentage' to display the percentage of hidden words, 'percentage visible' to display");
                        Console.WriteLine("the percentage of visible words, 'percentage all' to display the percentage of all words, or 'display' to display all information about the scripture:");
                        Console.WriteLine("\n", "\n");

                        string hideInput = Console.ReadLine();

                        if (hideInput.ToLower() == "quit")
                        {
                            return;
                        }
                        else if (hideInput.ToLowerInvariant() == "hide")
                        {
                            // Call the HideRandomWord method to hide a random word in the scripture. This will allow the user to hide a random word in the scripture each time they type "hide" when prompted to hide a word, regardless of how many verses are in the scripture.
                            // Call the DisplayScripture method again to display the updated scripture with the hidden word. This will allow the user to see the updated state of the scripture with hidden words after they hide a word.

                            //public string _myWord = Word Hide;
                        }
                        
                        else if (hideInput.ToLower() == "reset")
                        {
                            // Start a new instance of the Scripture class with a new scripture reference and text. This will allow the user to reset the scripture to its original state if they want to start over with hiding words.
                            // Call the DisplayScripture method again to display the original scripture.
                            continue;
                        }
                        else if (hideInput.ToLower() == "original")
                        {
                            // Call the DisplayScripture method again to display the original scripture. This will allow the user to see the original state of the scripture if they want to compare it to the current state of the scripture with hidden words.
                        }
                        else if (hideInput.ToLower() == "current")
                        {
                            // Call the DisplayScripture method again to display the current scripture with hidden words. This will allow the user to see the current state of the scripture with hidden words if they want to compare it to the original scripture.
                        }
                        else if (hideInput.ToLower() == "hidden")
                        {
                            // Display the number of words that are currently hidden in the scripture. This will allow the user to see how many words they have hidden in the scripture.
                        }
                        else if (hideInput.ToLower() == "visible")
                        {
                            // Display the number of words that are currently visible in the scripture. This will allow the user to see how many words are still visible in the scripture.
                        }
                        else if (hideInput.ToLower() == "percentage")
                        {
                            // Display the percentage of words that are currently hidden in the scripture. This will allow the user to see the percentage of words that they have hidden in the scripture.
                        }
                        else if (hideInput.ToLower() == "percentage visible")
                        {
                            // Display the percentage of words that are currently visible in the scripture. This will allow the user to see the percentage of words that are still visible in the scripture.
                        }
                        else if (hideInput.ToLower() == "percentage all")
                        {
                            // Display the percentage of words that are currently hidden and visible in the scripture. This will allow the user to see the percentage of words that they have hidden and the percentage of words that are still visible in the scripture.
                        }
                        else if (hideInput.ToLower() == "display")
                        {
                            // Display all information about the scripture, including the original scripture, current scripture, number of hidden words, number of visible words, percentage of hidden words, percentage of visible words, and percentage of all words. This will allow the user to see all the information about the scripture in one place if they want to see it.
                        }
                    }
               }
          }
     }

}