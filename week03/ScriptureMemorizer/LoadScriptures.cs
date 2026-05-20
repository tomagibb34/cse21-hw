// CSE 210 - Introduction to Programming
// Exercise 1 - Practice with Scripture Memorization
// Author: Tom Gibb
// Date: 05-14-2026

// The program will create a new instance of the ScriptureMemorizer class and call the DisplayScripture method to display the scripture to the user.
// The program will obtain the scripture reference from the user and then find that scripture reference in the scriptures.txt file.
// It will then store the scripture reference and text in separate strings within the ScriptureMemorizer class.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

class LoadScriptures
{
     public static void InitializeScriptures()
     {
          Console.WriteLine("Loading scriptures...");
          // Obtain the scripture reference from the user
          Console.WriteLine("Please enter the scripture reference you would like to load:");
          string reference = Console.ReadLine();
          // Find the scripture reference in the scriptures.txt file
          // Initialize a new list of strings to store the scripture text
          
          List<string> text = new List<string>();
          
          // Read the scriptures.txt file and find the scripture reference
          // Determine if the scripture reference is for multiple verses and if so, store the scripture reference and text in separate strings within the ScriptureMemorizer class. This will allow the user to hide a random word in the scripture each time they type "hide" when prompted to hide a word, regardless of how many verses are in the scripture.

          if (reference.Contains("-"))
          {
               // The scripture reference is for multiple verses
               string[] parts = reference.Split('-');
               string startReference = parts[0].Trim();
               string endReference = parts[1].Trim();
               // Read the scriptures.txt file and find the scripture references
               string startText = "";
               string endText = "";
               string[] lines = System.IO.File.ReadAllLines("scriptures.txt");
     
               foreach (string line in lines)
               {
                    if (line.StartsWith(startReference))
               {
                    startText = line.Substring(startReference.Length + 1);
               }
                    if (line.StartsWith(endReference))
               {
                    endText = line.Substring(endReference.Length + 1);
               }
                    if (startText != "" && endText != "")
               {                    
                    break;
               }
          }
          text = startText + " " + endText;
     }
          else
          {
               // The scripture reference is for a single verse     
               string[] lines = System.IO.File.ReadAllLines("scriptures.txt");
               foreach (string line in lines)
               {
                    if (line.StartsWith(reference))
               {
                    text = line.Substring(reference.Length + 1);
                    break;
               }
          }
     }

     // Store the scripture reference and text in separate strings within the ScriptureMemorizer class. This will allow the user to hide a random word in the scripture each time they type "hide" when prompted to hide a word.
     ScriptureMemorizer scriptureMemorizer = new ScriptureMemorizer(reference, text);

     DisplayScripture(scriptureMemorizer);
     }
}
