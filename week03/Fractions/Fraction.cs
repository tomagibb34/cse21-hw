// CSE 210 - Introduction to Programming
// Exercise 1 - Practice with fractions
// Author: Tom Gibb
// Date: 05-14-2026

// This class represents a fraction with a numerator and denominator.
// Define the private fields for the numerator and denominator, and include methods for performing operations on fractions.
// Define the properties and methods for the Fraction class here.
// You can include methods for adding, subtracting, multiplying, and dividing fractions,
// as well as simplifying the fraction and converting it to a decimal.

// Example properties and methods (you can expand this as needed):

// - Properties:
    // - Private Numerator: Gets or sets the numerator of the fraction.
    // - Private Denominator: Gets or sets the denominator of the fraction.

// - Methods:
    // - Add(Fraction other): Returns a new Fraction that is the sum of this fraction and another fraction.
    // - Subtract(Fraction other): Returns a new Fraction that is the difference between this fraction and another fraction.
    // - Multiply(Fraction other): Returns a new Fraction that is the product of this fraction and another fraction.
    // - Divide(Fraction other): Returns a new Fraction that is the quotient of this fraction and another fraction. 
    // - Simplify(): Simplifies the fraction to its lowest terms.

// - ToDecimal(): Converts the fraction to a decimal value.

// - Constructor: Initializes the numerator and denominator.
     // Constructor: With no parameters, initializes the fraction to 1/1.
     // Constructor: With one parameter, initializes the fraction to the given numerator and a denominator of 1.
     // Constructor: With two parameters, initializes the fraction to the given numerator and denominator.

// - ToString(): Overrides the ToString() method to display the fraction in a readable format

// Create a method called GetFractionsString that returns the fraction in the form "numerator/denominator".
// This method should be used in the ToString() method to display the fraction in a readable format.
// Create a method called GetDecimalValue that returns a double that is the result of dividing the numerator by the denominator.
// This method should be used to convert the fraction to a decimal value. 

public class Fraction
{
    private int numerator;
    private int denominator;

    // Constructors
    public Fraction()
    {
        numerator = 1;
        denominator = 1;
    }

    public Fraction(int num)
    {
        numerator = num;
        denominator = 1;
    }

    public Fraction(int num, int denom)
    {
        numerator = num;
        denominator = denom;
        Simplify();
    }

    // Properties
    public int Numerator
    {
        get { return numerator; }
        set { numerator = value; Simplify(); }
    }

    public int Denominator
    {
        get { return denominator; }
        set { denominator = value; Simplify(); }
    }

    // Methods for operations (Add, Subtract, Multiply, Divide) and Simplify would go here
    // TBD: Implement the logic for these methods based on the rules of fraction arithmetic.

    // ToString method to display the fraction
    public override string ToString()
    {
        return $"{numerator}/{denominator}";
    }

    public void Simplify()
    {
        // Implement the logic to simplify the fraction
        // This typically involves finding the greatest common divisor (GCD) of the numerator and denominator
        // and dividing both by that GCD.

        numerator = numerator / GCD(numerator, denominator);
        denominator = denominator / GCD(numerator, denominator); 
    }

     private int GCD(int numerator, int denominator)
     {
          if (denominator == 0)
          {
               throw new ArgumentException("Denominator cannot be zero.");
          }
          
          if (numerator == 0)
          {
               return Math.Abs(denominator);
          }
          
          while (denominator != 0)
          {
               int temp = denominator;
               denominator = numerator % denominator;
               numerator = temp;
          }
          return Math.Abs(numerator);
          
          // throw new NotImplementedException();
     }

     public double GetDecimalValue()
     {
          return (double)numerator / denominator;
     }

     public string GetFractionsString()
     {
          return $"{numerator}/{denominator}";
     }
}    