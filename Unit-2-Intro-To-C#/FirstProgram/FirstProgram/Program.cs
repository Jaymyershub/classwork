namespace FirstProgram;

//          this program will ask for 3 numbers,
//           add them together, and display the total.

//Programming Solution - Human Thinking
//Identify the detailed steps
//
//Ask for the numbers one at a time
//Write down each number as it is given
//Add the numbers together create a sum/total
//Tell the total (display)
//
//Now that we have the steps in our solution
//Identify any data/processes you need for the steps
//
//1. A place to write down each number - a variable in a program
//2. A place to hold the sum/total - a variable in a program
//3. A way to ask for the numbers - a method (object.method())
//4. A way to receive the numbers - a method (object.method())
//5. A way to report the total - a method (object.method())
//
//Place the steps in the order we need to solve the problem
//  1.Ask for the numbers one at a time
//      a.tell whoever is giving us the numbers to give me the first number
//      b. Receive the first number from the sender
//      c. Write down the first number
//      d.tell whoever is giving us the numbers to give me the second number
//      e. Receive the second number from the sender
//      f. Write down the second number
//      g.tell whoever is giving us the numbers to give me the third number
//      h. Receive the third number from the sender
//      i. Write down the third number
//
//  2. Add the numbers together create a sum/total
//      a. Add the first number to a sum/total
//      b. Add the second number to a sum/total
//      c. Add the third number to a sum/total
//
//  3. Tell the requester the total/sum (display)

class Program
{
    static void Main(string[] args)
    {
        /***************************************************************
         *define any data the program needs at the top of the program
         *
         * data may be defined anywhere before it is used, its easiesr to find at top
         *
         * to define a variable: data-type name = initial-value
         * 
         * Commonly used data types in C#:
         *  int     - Numeric value that is a whole number between +/- 2 billion
         *  long    - A whole number greater than +/- 2 billion
         *  double  - Numeric value with decimal places
         *  char    - A single alpha-numeric character
         *  string  - A series of aplha-numeric characters (words or sentence)
         *  bool    - true or false for conditions
         *
         *      EXAMPLES: 10 - int (or long)
         *                1.0 - double
         *                'a' - char (note it is enclosed in '')
         *        "some text" - string
         *
         *  Variable names C# are usually spelled in camelCase; use _ to seperate words, if you want to
         * (camelCase means the first letter is in lowercase all other
         *                words start with upper case letter)
         *
         * It's always a good to initialize variables when
         * defining them so you know whats in them
         ***************************************************************/
        
        //define the variables to hold the numbers we need to add
        int number1 = 0;
        int number2 = 0;
        int number3 = 0;
        
        //define a variable to hold the sum of the numbers
        int sum = 0;
        
        Console.WriteLine("---Starting Program---");
        
        //Ask for the numbers one at a time using the C# console object
        //           which represents the keyboard and screen
        //Console.ReadLine() returns a string - cannot store in an int
        
        Console.WriteLine("Please enter the first number: ");
        string aLine;   //----->//String to hold the line of input from the keyboard
        aLine = Console.ReadLine();               //Get a line from the keyboard
        //We need an int value to store our numbers
        // Console.ReadLine() only returns a string 
        //So we need to convert the string from Console.ReadLine() to an int
        //      ****int.Parse(string) will convert a string to an int****
        number1 = int.Parse(aLine);
        
        //Verify that I got the data I expected
        //Display some words and the value I received
        //"string" + something is called concatenation (it sticks them together)
        Console.WriteLine("You entered: " + number1);
        
        Console.WriteLine("---Ending Program");
    }
}