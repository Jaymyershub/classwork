namespace EXERCISE1_variables_n_types;

class Program
{
    static void Main(string[] args)
    {
        
        // *****EXERCISE 1.1*********
        
        /*Console.WriteLine("Please enter a sentence:  ");  // Ask user to type sentence
        string theResponse;      // String to hold the line of input from the keyboard
        theResponse = Console.ReadLine();    // Get the line from the kayboard
        Console.WriteLine(theResponse);//  repeat the line from user's keyboard  
*/

        
        
        //*******EXERCISE 1.2**********
        
       /* int number1 = 0;  //places to hold numbers
        int plusOne = 1;
        int sum;
            
            
        Console.WriteLine("Please enter a number to add the number 1 to:  ");  //ask user to type a number
        string theNumber;  //place to hold the user input
        theNumber = Console.ReadLine();  //ask user to type the number
        number1 = int.Parse(theNumber);  //turn string into a integer
        
        sum = number1 + plusOne;  //the formula / adding the numbers together
        
        Console.WriteLine("The sum of the numbers is: " + sum);  // give the answer
        */
       
       
       // ****** EXERCISE 1.3 **********
       
       /*
       double a = 0;
       double point5 = 0.5;
       double sum;
       
       Console.WriteLine("Enter a number to add 0.5 to : ");
       string myNumber;
       myNumber = Console.ReadLine();
       a = double.Parse(myNumber);
       
       sum = a + point5;
       Console.WriteLine(sum);

                        */


                //********EXERCICE 1.4 ***********
                
            
                
       double numeroUno = 0;  //make a place to store the numbers
       double numeroDos = 0;
       double sum;   //make a place to store the sum
       
       Console.WriteLine("Enter your first number: ");  //ask for the first number
       numeroUno = double.Parse(Console.ReadLine());  //you have to make it so that the string you input is 
                                                        //turned into a double
                                                        
       Console.WriteLine("Enter your second number: ");  //ask for the second number
       numeroDos = double.Parse(Console.ReadLine());  //turn string into a double
       
       sum = numeroUno + numeroDos;  //create the equation
       
       Console.WriteLine($"The sum is: {sum}");  //return the sum
       
            */


          
                  //**********EXERCISE 1.5************
                  
                  /*
          
          double multipleUno = 0;
          double multipleDos = 0;
          double sum = 0;
          
          Console.WriteLine("enter the first number: ");
          multipleUno = double.Parse(Console.ReadLine());
          
          Console.WriteLine("enter the second number: ");
          multipleDos = double.Parse(Console.ReadLine());
          
          sum = multipleUno * multipleDos;
          Console.WriteLine($"The sum is: {sum}");
          
          */

                  
                  
                  //*******EXERCISE 1.6*********

                  /*
                  
                  int firstDivision = 0;
                  int secondDivision = 0;
                  int sum = 0;
                  
                  Console.WriteLine("Enter first number: ");
                  firstDivision = int.Parse(Console.ReadLine());
                  
                  Console.WriteLine("Enter second number: ");
                  secondDivision = int.Parse(Console.ReadLine());
                  
                  sum = firstDivision / secondDivision;
                  Console.WriteLine($"The sum is: {sum}");
                  
                  //When dividing numbers that will have a remainder, the machine will just give you the whole #
                  
                  */
                  
                  
                  //*******EXERCISE 1.7**********
                  
        string theTruth = "true";
        string theFalse = "false";
        string myBoolean;
        
        Console.WriteLine("Enter either 'true' or 'false': ");
        myBoolean = Console.ReadLine();

        if (myBoolean == theTruth)
        {
            Console.WriteLine("false");
        } 
        if (myBoolean == theFalse)

        {
           Console.WriteLine("true"); 
        }
                  
    }
}