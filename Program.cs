using System;

namespace home3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start the program with Clear();
            Console.Clear();

            //This program will ask for user name input and print it back to them 

            Console.WriteLine(" What is your firstname"); 
            var fName = Console.ReadLine(); 

            Console.WriteLine(" What is your lastname"); 
            var lName = Console.ReadLine(); 

            Console.WriteLine(fName +  lName); 

            
            
            //End the program with blank line and instructions
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Press <Enter> to quit the program");
            Console.ReadKey();
        }
    }
}
