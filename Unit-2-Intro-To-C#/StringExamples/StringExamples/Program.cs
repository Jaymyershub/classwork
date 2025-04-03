namespace StringExamples;

class Program
{
    static void Main(string[] args)
    {
        /***************************************************************************
         * Strings in C# are a special data type - they dont work like you think they should
         *
         * Strings literals are enclosed in ""
         *
         * A literal is something that says what it is: 1 1.24 "Bob"
         *
         * string variables somethimes require special processing
         *      you cant us < > to compare strings
         *      BEWARE; early versions of C# does not allow use of == with strings
         *
         * C# provides several methods to operate on strings:
         *
         *      .Equals(string) - compare the string to the left of the . to the string inside ()
         *      .CompareTo(string) - return a number indicating how the first string relates to the second
         *                           return a negative number if the first string is less than the second
         *                           return a zero if the first string is less than the second
         *                           return a positive number if the first string is greater than the second
         * 
         ***************************************************************************/
        //if (condition) {
        //      What to do if condition is true
        // }
        //      What to do if condition is false
        // }
        string string1 = "a";
        string string2 = "b";
        
        Console.WriteLine("string1 is:" + string1);
        Console.WriteLine("string2 is:" + string2);
        
        if (string1.CompareTo(string2) > 0) //if the first string is greater than the second
        {
            Console.WriteLine("string1 is greater than string2");
        }
        else
        {
            Console.WriteLine("string1 is NOT greater than string2");
        }
        if (string1.CompareTo(string2) < 0) //if the first string is greater than the second
        {
            Console.WriteLine("string1 is less than string2");
        }
        else
        {
            Console.WriteLine("string1 is NOT less than string2");
        }
        if (string1.CompareTo(string2) == 0) //if the first string is greater than the second
        {
            Console.WriteLine("string1 is equal to string2");
        }
        else
        {
            Console.WriteLine("string1 is NOT equal to string2");
        }
    } //End of Main()
} //End of class program bracket