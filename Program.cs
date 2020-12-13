// Run C# in Vscode: go to view-->terminal then add: 
// dotnet new console --force
// dotnet build
// dotnet run 

using System;

namespace learning_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Hello World!"); // First hello world 
            // Prints a message to the same line 
            Console.Write("Congratulations");
            Console.Write(" ");
            Console.Write("You wrote your first lines of code");
            // Create a char literal 
            Console.WriteLine('b');
            // Int literal
            Console.WriteLine(123);
            // Decimal literal, the m is called a literal suffix (tells the compiler is  a decimal value)
            Console.WriteLine(12.3m);
            // Bool literal
            Console.WriteLine(true);
            Console.WriteLine(false);
            // Declaring a variable
            string firstName;
            // Assigning a variable 
            firstName = "Gladys";
            // Retrieve a value stored in a variable 
            Console.WriteLine(firstName);
            // Reassign the value of a variable 
            firstName = "Beth";
            // Initializing the variable 
            string value = "Bob";
            // Implicitly typed local variables (instructs the C# compiler to infer the type)
            var message = "Hello world!";
            // Challenge 
            string name = "Bob";
            int inbox = 3;
            decimal temperature = 34.4m;
            Console.WriteLine($"Hello, {name}! You have {inbox} in your inbox. The temperature is {temperature} celsius.");
    
        }
    }
}
