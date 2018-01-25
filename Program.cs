using System;

namespace milesToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start the program with Clear();
            Console.Clear();
            
            Console.WriteLine("Please chose: Miles or Kilometers ");                    
            var userChoise = Console.ReadLine();
            if(userChoise == "Miles")
            {
                Console.WriteLine("Please enter the number in Miles");
                double input = double.Parse(Console.ReadLine());      
                Console.WriteLine(input + " miles = " + (input * 1.61) + " Km" );
            }
            if(userChoise == "Kilometers")
            {
                Console.WriteLine("Please enter the number in Km");
                double input = double.Parse(Console.ReadLine());      
                Console.WriteLine(input + " Km = " + (input * 0.62) + " miles" ); 
            }
            
            //End the program with blank line and instructions
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Press <Enter> to quit the program");
            Console.ReadKey();
        }
    }
}
