namespace AddSomeNumbers;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("---Start of Program---");
        
        // Ask the user for 3 numbers, one at a time to produce a sum
        
        // 1.Do this 3 times - A loop allows...
        //      Ask user to enter a number
        //      Get the number from the user
        //      Add the number to the sum right away
        //
        // 2. Display the sum of the numebrs
        
        //Data we need:
        /*
         *  A. a place to hold the # entered by the user
         *  B. a place to hold the sum of the #'s
         */
        
        //Define a place to hold the number entered by the user
        int firstEntry = 0;
        
        //Define a place to hold the sum of the numbers
        int sum = 0;
        
        //Loop through our process 3 times
        //If you know the number of times you want to loop
        //      Use a for-loop
        //
        // Syntax of a for loop:
        //
        //          (1)                     (2)                     (3)
        //      initialization
        //
        //      for(int variable = initial-value; variable  < #-times-to-loop; variable++){
        //          }
        //
        //The for-loop is controlled by the variable defined within it:
        //
        //      1. int variable=initial-value - initializes the variable (usually to 0)
        //      2. the condition following the variable definition is tested:
        //          a. if true - perform the process between the {} for the for-loop
        //          b.   increment the variable according the lat part of the loop
        //             go back to #2
        //          c. if false - exit the loop after closing bracket
        //      3. 
        
        for (int i=0; i < 3; i++) // i=0, 1, 2 inside the loop - 3 causes it to exit
        
        //Ask the user to enter a number
        Console.WriteLine("Enter First Number: ");
        //Get the number they enter
        string theUserResponse = Console.ReadLine();  //get the data from keyboard
        firstEntry = int.Parse(theUserResponse);  //convert the data to int
        
        //ALT way to get the # w/o using a string var (combine multiple statements into one)
        //  firstEntry = int.Parse(Console.ReadLine());
        
        //Add the number to the sum
        sum = sum + firstEntry; // sum += firstEntry; works too
        
        //Display
        Console.WriteLine(sum);
        
        Console.WriteLine("---End of Program---");
    }
}