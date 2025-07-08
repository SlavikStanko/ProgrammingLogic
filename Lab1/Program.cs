namespace Lab1;

class Program
{
    static void Main(string[] args)
    {
        /*
            Name: Vyacheslav Stanko
            Title: IT-1050 - Lab 1
           */

        // Step 2: Basic Output
        Console.WriteLine("Vyacheslav Stanko IT-1050");

        // Step 3: Declare and Use Variables
        int favoriteNumber = 7;
        string favoriteLanguage = "Html";
        double programsWritten = 0.5;
        bool hasExperience = false;
        Console.WriteLine("Favorite number (int): " + favoriteNumber);
        Console.WriteLine("Favorite language (string): " + favoriteLanguage);
        Console.WriteLine("Programs written (double): " + programsWritten);
        Console.WriteLine("Has programming experience? (bool): " + hasExperience);

        // Step 4: Use Constants
        const string schoolName = "Cuyahoga Community College";
        Console.WriteLine("School Name (constant): " + schoolName);

        // Step 5: Type Casting
        double DoubleValue = 9.78;
        int castedInt = (int)DoubleValue;

        int intToConvert = 42;
        bool boolToConvert = false;

        string intAsString = Convert.ToString(intToConvert);
        string boolAsString = Convert.ToString(boolToConvert);

        Console.WriteLine("Original double: " + DoubleValue);
        Console.WriteLine("Casted to int: " + castedInt);
        Console.WriteLine("Int to string: " + intAsString);
        Console.WriteLine("Bool to string: " + boolAsString);

        // Step 6: User Input and Type Conversion
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine()!;
        Console.Write("Enter your age: ");
        int userAge = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Hello, " + userName + "You are " + userAge + " years old.");

        // Step 7: Arithmetic Operators
        int num1 = 10;
        int num2 = 5;
        Console.WriteLine("Addition (num1 + 10): " + (num1 + 10));
        Console.WriteLine("Subtraction (num2 - 2): " + (num2 - 2));
        Console.WriteLine("Multiplication (num1 * 3): " + (num1 * 3));
        Console.WriteLine("Division (num1 / 2): " + (num1 / 2));
        Console.WriteLine("Modulus (num1 % 2): " + (num1 % 2));

        // Step 8: Floating Point Precision
        float floatNumber = 1.123456789f;
        double doubleNumber = 1.123456789;
        Console.WriteLine("Float value: " + floatNumber);
        Console.WriteLine("Double value: " + doubleNumber);

        // Step 9: Increment and Decrement
         int count = 10;
        count++;
        Console.WriteLine("After increment (++): " + count);
        count--;
        Console.WriteLine("After decrement (--): " + count);
    }
}

