using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("Please enter you current grade? ");
        int grade = int.Parse(Console.ReadLine());
        string letterGrade = "";
        string letterSign = "";

        if (grade >= 90)
        {
            letterGrade = "A";
            if (grade <= 93)
            {
                letterSign = "-";
            }        
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
            if (grade <= 83)
            {
                letterSign = "-";   
            }
            else if (grade >= 87)
            {
                letterSign = "+";
            }
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
            if (grade <= 73)
            {
                letterSign = "-";   
            }
            else if (grade >= 77)
            {
                letterSign = "+";
            }
        }
        else if (grade >= 60)
        {
           letterGrade = "D";
            if (grade <= 63)
            {
                letterSign = "-";   
            }
            else if (grade >= 67)
            {
                letterSign = "+";
            }   
        }
        else
        {
            letterGrade = "F";
        }

        
        if (grade >= 60 && grade <= 100)
        {
            letterGrade += letterSign;
        }

        if (grade < 0 || grade > 100)
        {
            Console.WriteLine("Invalid grade entered.");
        }
        else
        {
            if (grade >= 70)
            {
                Console.WriteLine("Congratulations! You passed the class.");
            }
            Console.WriteLine($"Your letter grade is {letterGrade}.");
        }


    }
}