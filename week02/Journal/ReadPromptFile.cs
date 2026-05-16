using System;
using System.IO;  // This library is used for file handling operations, such as reading from and writing to files.
using System.Collections.Generic;  // This library is used for collections, such as lists and dictionaries, which will be used to store the journal entries in memory.


public class ReadPromptFile
{
    public string _fileName;  // This variable will be used to store the name of the file that contains the prompts.
    // It is declared as a public variable, which means that it can be accessed from outside the class.

    // This method will be used to read prompts from a file. It will take the name of the file as a parameter, and it will return a list of prompts that were read from the file.
    public List<string> ReadPromptsFromFile(string _fileName)
    {
        List<string> _prompts = new();  // This will create a new list of strings to store the prompts that are read from the file.

        using (StreamReader inputFile = new(_fileName))  // This will create a new StreamReader object, which will be used to read from the file specified by the _fileName parameter. The using statement ensures that the StreamReader object is properly disposed of after it is used, which will help to prevent memory leaks and other issues that can arise from not properly managing resources.
        {
            string line;  // This variable will be used to store each line of text that is read from the file.
            while ((line = inputFile.ReadLine()) != null)  // This will loop through each line of text in the file until it reaches the end of the file (when ReadLine() returns null).
            {
                _prompts.Add(line);  // This will add the current line of text (which represents a prompt) to the list of prompts.
            }
        }

        return _prompts;  // This will return the list of prompts that were read from the file.
    }
}
