namespace StringExamples;

class Program
{
    static void Main(string[] args)
    {
        /***************************************************************************************************
         * Strings in C# are a special data type - they don't work like you think they should
         *
         * String literals are enclosed in " "
         *
         * A literal is something that says what it is:  1 1.24 "Bob"
         *
         * string variables sometimes require special processing
         *        you can't use < > to compare strings
         *        Beware: Early versions of C# do not allow use of == with strings
         *
         * a method() is a program that processes data in an object/variable
         *
         * C# provides several methods to operate on strings:
         *
         *     .Equals(string) - compare the string to left of the . to string inside () for equals
         *     .CompareTo(string) - return a number indicating how the first string relates to the second
         *                          return a negative number if first string is less than the second
         *                          return a zero if first string is equal the second
         *                          return a positive number if first string is greater than the second
         ***************************************************************************************************/
        // if (condition) {
        //    What to do if condition is true
        // }
        // else {
        //    What to do if condition is false
        // }
        string string1 = "a";
        string string2 = "b";
        
        Console.WriteLine("string1 is: " + string1);
        Console.WriteLine("string2 is: " + string2);
        
        if (string1.CompareTo(string2) > 0) // if the first string is greater than second string
        {
            Console.WriteLine("string1 is greater than string2");
        }
        else
        {
            Console.WriteLine("string1 is NOT greater than string2");
        }
        if (string1.CompareTo(string2) < 0) // if the first string is greater than second string
        {
            Console.WriteLine("string1 is less than string2");
        }
        else
        {
            Console.WriteLine("string1 is NOT less than string2");
        }
        if (string1.CompareTo(string2) == 0) // if the first string is equal second string
        {
            Console.WriteLine("string1 is equal string2");
        }
        else
        {
            Console.WriteLine("string1 is NOT equal string2");
        }
        // ********* SOME METHODS THAT PROCESS STRINGS **********
        // To see a list of all methods available to an object - just type the objectName.
        // .Length - returns the number of characters in a string
        // .Contains(string) - returns true if the string given is inside the string 
        // .Substring(start-index,length) - extract characters from thw string starting at the start index
        //                                  for the numbers characters indicated by the length
        //                                  start-index starts at 0 NOT 1
        //                                  whenever you see the word index -starts counting at 0
        
        // .StartsWith(string) - return True if string starts with the specified characters (CASE SENSITIVE)
        // .EndsWith(string) - return True if string ends with the specified characters (CASE SENSITIVE)
        // .Trim() - removes any leading or trailing spaces
        //
        
        //.                01234567891123456789212345678931234567894123
        string sentence = "   My name is Jaysin and I am learning C#   ";
        Console.WriteLine("There are " + sentence.Length + " characters in the sentence");
        
        bool containsJaysin = sentence.Contains("Jaysin"); //True if the sentence contains Jaysin
        Console.WriteLine("Does sentence contain Jaysin: " + containsJaysin);
        
        Console.WriteLine("Does sentence contain Olive: " + sentence.Contains("Olive"));

        string nameInSentence = sentence.Substring(11, 6); // Extract the 6 chars starting at position 12
        Console.WriteLine("The name is: " + nameInSentence);
        
        Console.WriteLine("Results when sentence.Trim() is used to reomove leading and trailing spaces: " + sentence);
        Console.WriteLine("Does the sentence start with My? " + sentence.Trim().StartsWith("My"));
        Console.WriteLine("Does the sentence start with my? " + sentence.Trim().StartsWith("my"));
        Console.WriteLine("Does the sentence end with C#? " + sentence.Trim().EndsWith("C#"));
        
        // When C# sees a statement with chained-operations (operations seperated by .)
        // C# Process the statement from left to right, one operation at a time
        // Then, it uses the result of the operation in the next one
        //
        // sentence.Trim().EndsWith("C#")
        //
        // 1.   sentence.Trim().EndsWith("C#") - returns a string with the leading and trailing spaces removed
        // 2.   results-from-step-1.EndsWith() - return a true or false depending on if the string actuallu ends with C#
        //

    } // End of Main()
}  // End of class Program