using System;
using System.IO;  // This library is used for file handling operations, such as reading from and writing to files.
using System.Collections.Generic;  // This library is used for collections, such as lists and dictionaries, which will be used to store the journal entries in memory.


public class DisplayJournal
{
     public string _fileName;

     // This method will be used to display the journal entries that are stored in memory. It will take a list of journal entries as a parameter, and it will loop through each entry in the list and display it to the user.
     public void DisplayEntries(List<string> journalEntries)
     {
         foreach (string entry in journalEntries)  // This will loop through each journal entry in the list of journal entries.
         {
             Console.WriteLine(entry);  // This will display the current journal entry to the user.
         }
     }  
}
