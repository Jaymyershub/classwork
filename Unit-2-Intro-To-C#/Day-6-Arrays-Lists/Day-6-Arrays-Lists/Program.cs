namespace Day_6_Arrays_Lists;

// This program will ask for three numbers
//      add them together and display the total

class Program
{
    static void Main(string[] args)
    {
        // Define an array to hold 3 numbers
        
        int[] numbers = new int[3];  //numbers.Length=3; 2 is the largest allowable index
        int sum = 0;  // Define a variable to hold the sum of the numbers

        //normally we process an array from beginning to end  (from the first element to the lst element, one at a time)
        //
        //a for-loop will loop through a process counting as it does so
        //a for-loop is a great tool for processing an array from start to end.
        //
        // standard syntax: for(i=0; i < arrayName.Length; i++
        //                     arrayName.Length represents the number of elements in the array
        
        //. index.      loop as long.      
        //. start.      as the index.        incrememnt the index
        //. at 0.       isnt outside array.  for each loop
        for (int i = 0; i < numbers.Length; i++) //i = 0, 1, 2 inside loop and 3 when exit loop
        {
            Console.WriteLine("Enter number: ");
            numbers[i] = int.Parse(Console.ReadLine());  //get a string from key board, convert into int, and store is in numbers[i]
        }
        
        //Verify the array recieved the numbers correctly
        // Go through the array one element at a time & display the element

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Element " + i + " is: " + numbers[i]);
            sum = sum + numbers[i]; //add the current number in the array to sum
        }
        
        //sum = number1 + number2 + number3 + number4 + number5;
       
        // Tell the requester the sum/total (display)
        Console.WriteLine("The sum is: " + sum);
        
        // Tell the requester the average of the numbers
        //Divide sum by # of elements in the Array (arrayname.Length)
        
        
        // Note the cast of sum to a double so we get decimal places in the results
        Console.WriteLine("The average of the numbers is " + (double) sum / numbers.Length);
        
        //sum / numbers.Length
        //int / int ---> integer arithmetic - divide gives two parts: quotient and remainder
        //   int                                   7 / 3 - quotient=2 remainder=1
        
        //***CASTING***
        // (double) sum / numbers.Length
        // convert sum
        // to double    / int ----> floating point arithmetic
        
        //              / convert int to double (C# does this automatically)
        //  double      / double ---> floating point arithmetic
        //      double (2.333)
        
        
        
        
        
        //****END OF PROGRAM****
    }
}