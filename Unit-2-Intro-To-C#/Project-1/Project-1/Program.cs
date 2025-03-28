/*
 * this is a block comment - everything between the
 * slash-asterisk and ast-slash
 * is ignored. this is useful for large contents
 * of text OR to deacitvate code.
     The * as the start of each line is optional.
 */

// A namespace identifies a context in which a word is known.
//   allows the same name to be used in different contexts to mean different things

namespace Project_1;

//Everything in C# is defined in a Class
//a Class is a group of related "things"
// A Class starts with the class keyword
class Program
// { } surround blocks of related code AKA code-blocks
{
    //Every application has a method called Main()
    //A method is a self-contained set of code that performs a function
    //Also known as: a function or a program
    //a method may return a value and accept data to process
    //method signiture identifies what the method returns, its name, and what it accepts
    //              return-type name (data-it-accepts)
    
    //Main() is where every application starts
    //Every appliction has ONE Main() method
    
    //Below Main() is a method that returns void and accepts a string called arg
    
    //Void means it returns nothing
    //static means there can be one of these in the block or code (Program Class)
    
    //      Return
    //      type name(date it accepts)
    static void Main(string[] args)
    { //Start of the code for Main()
        // This code will display whatever is between the ("") on the screen
        
        //Console is an object defined by C# to represent the screen
        //An object has certain behaviors 
        //A behavior is something an object can do with data
        //behaviors are implemented using methods
        
        //object.method(data) = object oriented programming
        //
        //when you see a "." after a name, the name left of the "." is probably an object.
        //                 name( , the name is a method
        //                  name after the ., the name is usually a method
        
        //  object.method(data-for-the-method-to-process)
        Console.WriteLine("Hello, World!"); //EVERY C# STATEMENT ENDS IN A ;
    }
}