using System;

public class Program
{
    // Static allows the function to run without creating an object previously
    static void Main(string[] args)
    {
        Console.WriteLine("This will be deleted with Clear()");

        Console.ForegroundColor = ConsoleColor.Black;
        // Change only background colour of text
        Console.BackgroundColor = ConsoleColor.White;
        // Have the background colour apply to the entire window:
        Console.Clear();
        Console.WriteLine("Hello World");
        // Query the user
        Console.Write("Enter your name: ");
        // Accept user input on the console and store what they typed into object "name"
        string name = Console.ReadLine();
        //Console.WriteLine("Hello " + name);
        Console.WriteLine($"Hello {name}");

        // boolean value (true/false)
        bool canIVote = true;

        // Largest value you can store inside an integer
        Console.WriteLine("Biggest Integer: {0}", int.MaxValue);

        // Smallest value you can store inside an integer
        Console.WriteLine("Smallest Integer: {0}", int.MinValue);

        // Largest value you can store inside a long
        Console.WriteLine("Biggest Long: {0}", long.MaxValue);

        // Smallest value you can store inside a long
        Console.WriteLine("Smallest Long: {0}", long.MinValue);

        // 28 digits worth of percision in the decimal position. End it with M
        decimal decPiVal = 3.14159M;

        decimal decBigNum = 3.00000000000000000000011M;

        Console.WriteLine("Dec : Pi + bigNum = {0}", decPiVal + decBigNum);

        // Largest value you can store inside a decimal
        Console.WriteLine("Biggest Decimal: {0}", decimal.MaxValue);

        // Smallest value you can store inside a decimal
        Console.WriteLine("Smallest Decimal: {0}", decimal.MinValue);

        // Largest value you can store inside a double
        Console.WriteLine("Biggest Double: {0}", double.MaxValue);

        // Smallest value you can store inside a double
        Console.WriteLine("Smallest Double: {0}", double.MinValue);

        // Largest value you can store inside a float. End floats with an upper case F.
        Console.WriteLine("Biggest Float: {0}", float.MaxValue);

        // Smallest value you can store inside a double
        Console.WriteLine("Smallest Float: {0}", float.MinValue);

        // Convert from String
        bool boolFromStr = bool.Parse("true");
        int intFromStr = int.Parse("100");
        double dblFromStr = double.Parse("1.234");

        // Convert into String
        string strVal = dblFromStr.ToString();

        Console.WriteLine($"Data type: {strVal.GetType}");

        // Explicit conversion (you're losing some data). ex double into an integer means you lose the decimal values.
        double dblNum = 12.345;
        Console.WriteLine($"Integer from a double: {(int)dblNum}"); // Converts the double dblNum into an integer by simply using (data-type)value

        // Implicit conversion (converting into a larger data type)
        int intNum = 10;
        long longNum = intNum;
        Console.WriteLine("-------------------------");

        /* 
         * Format output
        */

        Console.WriteLine("Currency: {0:c}", 23.455); // c to format as currency ($23.45)
        Console.WriteLine("Pad with 0s: {0:d4}", 23); // Will add 0s at the start of the value given to take up as many spaces after d
        Console.WriteLine("Three Decimals: {0:f3}", 23.455123); // Will end decimal value at given number after f and automatically round
        Console.WriteLine("Commas: {0:n4}", 2300); // Number after n determines amount of decimal values.
        Console.WriteLine("-------------------------");

        /* 
         * Strings
        */

        string randString = "This is a string";
        // Get length of a string
        Console.WriteLine("String Length : {0}", randString.Length);
        // Contains a string
        Console.WriteLine("String Contains 'is' : {0}", randString.Contains("is"));
        // Find the index of a string
        Console.WriteLine("Index of 'is' : {0}", randString.IndexOf("is")); // Will return 2, since the first instance of "is" is inside "This"
        // Remove the number of characters starting at a specific index
        Console.WriteLine("Remove String : {0}", randString.Remove(10, 6)); // at index 10, remove 6
        // Ass a string at a specific index
        Console.WriteLine("Insert String: {0}", randString.Insert(10, "short ")); // at index 10, add "short "
        // Replace a string inside of a string
        Console.WriteLine("Replace String : {0}", randString.Replace("string", "setence")); // if string exists, replace with setence
        // Compare strings and ignore case
        Console.WriteLine("Compare A to B : {0}", String.Compare("A", "B", StringComparison.OrdinalIgnoreCase));
        Console.WriteLine("Compare A to a : {0}", String.Compare("A", "a", StringComparison.OrdinalIgnoreCase));
        /*
         * Reading the return for compare:
         * < 0 means that the first string is before the second.
         * 0 for when they are the same
         * > 0 means that the first string is after the second.
         */
        Console.WriteLine("-------------------------");

        /*
         * Formatting Strings
        */

        // Will pad from the left side of the console the number of spaces given, with '.' until string begins.
        Console.WriteLine("Pad Left: {0}", randString.PadLeft(30, '.'));
        // Will pad from the right side of the console the number of spaces given, with '.' until string ends.
        Console.WriteLine("Pad Right: {0}", randString.PadRight(20, '.'));
        // Trim white space (remove any excess white space at beginning or end)
        Console.WriteLine("Trim : {0}", randString.Trim());
        // Convert to all uppercase
        Console.WriteLine("Uppercase : {0}", randString.ToUpper());
        // Convert to all lowercase
        Console.WriteLine("Lowercase : {0}", randString.ToLower());

        // Use Format to create a string
        string newString = String.Format("{0} saw a {1} {2} in the {3}", "Paul", "rabbit", "eating", "field");
        // Add a new line
        Console.WriteLine(newString+"\n");
        // Escape character examples = \'  \\  \t  \a  \n
        Console.WriteLine(@"Start with an @ to prevent escape characters \n");

    }
}
