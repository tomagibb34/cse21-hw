using System;
using System.IO;  // This library is used for file handling operations, such as reading from and writing to files.
using System.Collections.Generic;  // This library is used for collections, such as lists and dictionaries, which will be used to store the journal entries in memory.


public class WriteJournalFile
{
     public string _fileName;

     // This will be used to store the journal entries in memory.
     // This will allow the program to display the entries and save them to a file when the user selects the corresponding options.
  
     public List<string> journalEntries;

     // This method will be used to write journal entries to a file. It will take a list of journal entries as a parameter, and it will write each entry to the file specified by the _fileName variable.
     public void WriteToFile(List<string> journalEntries)
    {
        using (StreamWriter outputFile = new(_fileName))  // This will create a new StreamWriter object, which will be used to write to the file specified by the _fileName variable. The using statement ensures that the StreamWriter object is properly disposed of after it is used, which will help to prevent memory leaks and other issues that can arise from not properly managing resources.
        {
           // Code to write journal entries to the file will go here.
           // This will loop through each journal entry in the list of journal entries, and it will write each entry to the file using the StreamWriter object.
           foreach (string entry in journalEntries)
           {
               outputFile.WriteLine(entry);  // This will write the current journal entry to the file, followed by a new line character to separate it from the next entry.
           }
        }
    }
}
