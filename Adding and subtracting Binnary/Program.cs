using System;

class BinaryOperations
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter first binary number:");
        string binary1 = Console.ReadLine();  // Step 1: Read first binary number from user

        Console.WriteLine("Enter second binary number:");
        string binary2 = Console.ReadLine();  // Step 2: Read second binary number from user

        // Validate the input strings
        if (!IsBinary(binary1) || !IsBinary(binary2))
        {
            Console.WriteLine("Invalid binary number entered. Please enter valid binary numbers.");
            return;
        }

        // Step 3: Convert binary strings to integers
        int num1 = Convert.ToInt32(binary1, 2);
        int num2 = Convert.ToInt32(binary2, 2);

        // Step 4: Perform addition and display result
        int sum = num1 + num2;
        string binarySum = Convert.ToString(sum, 2);
        Console.WriteLine($"Addition of {binary1} and {binary2} is: {binarySum}");

        // Step 5: Perform subtraction and handle different cases
        int difference = num1 - num2;
        if (difference < 0)
        {
            Console.WriteLine($"Subtraction of {binary2} from {binary1} results in a Negative Result ({difference})");
        }
        else
        {
            string binaryDifference = Convert.ToString(difference, 2);
            Console.WriteLine($"Subtraction of {binary2} from {binary1} is: {binaryDifference}");
        }
    }

    static bool IsBinary(string input)
    {
        return Regex.IsMatch(input, "^[01]+$");
    }
}
