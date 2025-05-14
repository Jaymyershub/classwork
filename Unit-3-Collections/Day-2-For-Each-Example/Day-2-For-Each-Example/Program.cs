namespace Day_2_For_Each_Example;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to an Example of a For-Each Loop");
        //Ask the writer to enter a sentence
        //(series of words seperated by whitespace - space, tab, something you cant see)
        //Display each word in the sentence
        
        Console.WriteLine("Please enter a sentence:");
        string sentence = Console.ReadLine();  //Get what they type and put it in a string
        
        // .split() will extract parts of a string into an array based on characters inside ()
        string[] splitSentence = sentence.Split(" ");  // split the sentence into words
        
        //Display each word in the sentence arrayName.Length returns the number of elements
        for (int i = 0; i < splitSentence.Length; i++)
        {
            //Note: to add 1 and i and use in the string we have to put it in ()
            // .WriteLine() treats everything you give it as a string
            //      + for a string means concatenate
            //      + for a numeric means add
            //      i+1 in the output for WriteLine,
            //          it thinks I want to take the value of i and stick a 1 after it
            //          (i+1) - () indicate do this first - add 1 to i and then use it in WriteLine output
            Console.WriteLine("Word #: " + (i+1) + " is: " + splitSentence[i]);
        }
        Console.WriteLine("----foreach example result follows----");
        //for-each loop can also process arrays and Lists
        //
        //Syntax:   foreach(datatype variable.name in array-or-List)
         //           datatype is the type of data in the array or List
         //           use the variable name inside the foreach loop to access on element in the variable
         //
         //for-loop vs for-each
         //
         //Both can process an array or list from beginning to end
         //for-loop can start and end at any element by setting int i= and changing the condition
         // for-each always processes from the beginning to end
         // for-loop you know which element you are processing by using the value in i
         // for-each loop you do not know which element youre processing

        foreach (string aWord in splitSentence)
        {
            Console.WriteLine(aWord);
        }
    }
}