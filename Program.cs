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
            // Escape character sequence (the \n sequence will add a new line, and a \t sequence will add a tab.)
            Console.WriteLine("Hello\nWorld!");
            Console.WriteLine("Hello\tWorld!");
            // Handle the double double quotes
            Console.WriteLine("Hello \"Enrique\"!");
            // Display a path file just double escape 
            Console.WriteLine("c:\\source\\repos");
            // Verbatim string literal (use the @)
            Console.WriteLine(@"   c:\source\repos   
            (this is where your code goes)");
            // Unicode escape characters  (using the \u, character in Unicode (UTF-16))
            Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");
            // Format output example 
            Console.WriteLine("Generating invoices for customer \"ABC Corp\" ...\n");
            Console.WriteLine("Invoice: 1021\t\tComplete!");
            Console.WriteLine("Invoice: 1022\t\tComplete!");
            Console.WriteLine("\nOutput Directory:\t");
            Console.Write(@"c:\invoices");
            // To generate Japanese invoices:
            // Nihon no seikyū-sho o seisei suru ni wa:
            Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
            Console.WriteLine(@"c:\invoices\app.exe -j");

            // String concatenation operator 
            Console.WriteLine("Hello " + firstName);
            // Interpolation expression 
            string greeting = "Hey";
            Console.WriteLine($"{greeting} {firstName}!");
            // Combine verbatim literals and string interpolation 
            string projectName = "First-Project";
            Console.WriteLine($@"C:\Output\{projectName}\Data");
            // Challenge 
            //string projectName = "ACME";
            //string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
            //Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");
            
           // string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
           // string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
           // Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");
        }
    }
}
