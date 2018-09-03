using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Title:   Q3 - Car (Assignment 1A)
Author:     John Elder
Date:       17/08/2018
Purpose:    New console application which also includes a Car class that matches the updated UML class diagram created in question 2.
*/

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
                Car car1 = new Car("","","");  // Defined Class = New Car

                Console.WriteLine("Enter new car details below \n \nPlease enter the colour:");  //Asking the user to enter what Colour their car is.
                car1.Colour = Console.ReadLine();
                    
                Console.WriteLine("Please enter the make of the car:");                //Asking the user to enter what Make their car is.
                car1.Make = Console.ReadLine();

                Console.WriteLine("Please enter the gear transmission:");             //Asking the user to enter what Transmission their car is.
                car1.GearBox = Console.ReadLine();

                Console.WriteLine();

                Console.WriteLine($"This car is a " + car1.Colour + " " + car1.Make + " with " + car1.GearBox + " transmission "); // Displaying the user's input that was entered and into a sentence.
                Console.WriteLine();

                Console.WriteLine("Thank You and Have a great day");
                Console.ReadLine();
            
        }


    class Car
       {
     
       public string Colour { get; set; }                   //The auto-implemented properties
       public string Make { get; set; }
       public string GearBox { get; set; }

      public Car( string _col, string _mk, string _gbox)    //Constructor
         {
            Colour = _col;
            Make = _mk;
            GearBox = _gbox;
         }


       }
    }
}

