using System;
using System.IO;  // This library is used for file handling operations, such as reading from and writing to files.
using System.Collections.Generic;  // This library is used for collections, such as lists and dictionaries, which will be used to store the journal entries in memory.


public class ReadJournalFile
{
     public string _fileName;

     // This method will be used to read journal entries from a file. It will take the name of the file as a parameter, and it will return a list of journal entries that were read from the file.
     public List<string> ReadFromFile(string fileName)
     {
         List<string> journalEntries = new();  // This will create a new list of strings to store the journal entries that are read from the file.

         using (StreamReader inputFile = new(fileName))  // This will create a new StreamReader object, which will be used to read from the file specified by the fileName parameter. The using statement ensures that the StreamReader object is properly disposed of after it is used, which will help to prevent memory leaks and other issues that can arise from not properly managing resources.
         {
             string line;  // This variable will be used to store each line of text that is read from the file.
             while ((line = inputFile.ReadLine()) != null)  // This will loop through each line of text in the file until it reaches the end of the file (when ReadLine() returns null).
             {
                 journalEntries.Add(line);  // This will add the current line of text (which represents a journal entry) to the list of journal entries.
             }
         }

         return journalEntries;  // This will return the list of journal entries that were read from the file.
     }
     


}
