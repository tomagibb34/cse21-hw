// CSE 210 - Introduction to Programming
// Exercise 4 - List numbers exercise.
// Purpose: To practice using lists and loops in C#.
// Instructions:
// 1. Create a new C# console application project.
// 2. Create a list of integer numbers by allowing the user to input values.
// 3. Use a loop to display each number in the list.
// 4. Calculate and display the sum of the numbers in the list.
// 5. Calculate and display the average of the numbers in the list.
// 6. Handle any potential exceptions that may occur during user input.
// 7. Include comments in your code to explain the functionality of each part.
// 8. Display the mean and standard deviation of the numbers in the list.
// 9. Find the maximum, or largest, number in the list and display it to the user.
// 10. Find the minimum, or smallest, number in the list and display it to the user.
// 11. Output the numbers in the list in sorted order (from smallest to largest).
// 12. Output the numbers in the list in reverse sorted order (from largest to smallest).
// 13. Process the list and display the smallest positive number in the list. If there are no positive numbers, display a message indicating that.
// Example Output:
// Enter a number (or type 'done' to finish): 5
// Enter a number (or type 'done' to finish): 10
// Enter a number (or type 'done' to finish): 15
// Enter a number (or type 'done' to finish): done
// Numbers entered:
// 5
// 10
// 15
// Sum: 30
// Average: 10
// Author: Tom Gibb
// Date: 05-04-2026

using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise 4 Project.");

        // Create a list to store the numbers entered by the user

        List<int> numbers = new List<int>();

        // Loop to allow the user to enter numbers until they type 'done'

        while (true)
        {   
            Console.Write("Enter a number (or type 'done' to finish): ");
            string input = Console.ReadLine();

            // Check if the user wants to finish input
            if (input.ToLower() == "done")
            {
                break;
            }

            try
            {
                // Try to parse the input as an integer
                int number = int.Parse(input);
                numbers.Add(number); // Add the number to the list
            }
            catch (FormatException)
            {
                // Handle the case where the input is not a valid integer
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }

        // Display the numbers entered by the user

        Console.WriteLine("Numbers entered:");
        
        foreach (int num in numbers)
        
        {
            Console.WriteLine(num);
        }

        // Calculate and display the sum of the numbers
        
        int sum = 0;

        foreach (int num in numbers)
        {
            sum += num;
        }
        
        Console.WriteLine($"Sum: {sum}");

        // Calculate and display the average of the numbers
        
        if (numbers.Count > 0)
        
        {
            double average = (double)sum / numbers.Count;
            Console.WriteLine($"Average: {average}");
        }   
        
        else
        
        {
            Console.WriteLine("No numbers were entered to calculate the average.");
        }

        // Calculate and display the mean and standard deviation of the numbers

        if (numbers.Count > 0)
        
        {
            double mean = (double)sum / numbers.Count;
            double variance = 0;

            foreach (int num in numbers)
            {
                variance += Math.Pow(num - mean, 2);
            }
            variance /= numbers.Count;
            double standardDeviation = Math.Sqrt(variance);

            Console.WriteLine("Mean: " + mean);
            Console.WriteLine("Standard Deviation: " + standardDeviation);
        }
        
        else
        
        {
            Console.WriteLine("No numbers were entered to calculate the mean and standard deviation.");
        }
        // Find and display the maximum and minimum numbers in the list
        if (numbers.Count > 0)
        
        {
            int max = numbers[0];
            int min = numbers[0];

            foreach (int num in numbers)
            {
                if (num > max)
                {
                    max = num;
                }
                if (num < min)
                {
                    min = num;
                }
            }

            Console.WriteLine($"Maximum number: {max}");
            Console.WriteLine($"Minimum number: {min}");
        }

        // If no numbers were entered, display a message indicating that maximum and minimum cannot be calculated
                
        else
        
        {
            Console.WriteLine("No numbers were entered to find the maximum and minimum.");
        }
        
        // Output the numbers in sorted order (from smallest to largest)
        
        if (numbers.Count > 0)
        
        {
            numbers.Sort();
            Console.WriteLine("Numbers in sorted order (smallest to largest):");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
        
        else
        
        {
            Console.WriteLine("No numbers were entered to sort.");
        }

        // Output the numbers in reverse sorted order (from largest to smallest)
        
        if (numbers.Count > 0)
        
        {
            numbers.Reverse();
            Console.WriteLine("Numbers in reverse sorted order (largest to smallest):");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
        
        else
        
        {
            Console.WriteLine("No numbers were entered to sort in reverse order.");
        }

        // Process the list and display the smallest positive number in the list. If there are no positive numbers, display a message indicating that.
        
        if (numbers.Count > 0)
        
        {
            int smallestPositive = int.MaxValue;
            bool foundPositive = false;

            foreach (int num in numbers)
            {
                if (num > 0 && num < smallestPositive)
                {
                    smallestPositive = num;
                    foundPositive = true;
                }
            }

            if (foundPositive)
            {
                Console.WriteLine($"Smallest positive number: {smallestPositive}");
            }
            else
            {
                Console.WriteLine("No positive numbers were entered.");
            }
        }
        
        else
        
        {
            Console.WriteLine("No numbers were entered to find the smallest positive number.");
        }

        // End of the program

        Console.WriteLine("Thank you for using the program. Goodbye!");
    }
}   