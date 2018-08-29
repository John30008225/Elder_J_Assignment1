using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1___Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Car car1 = new Car();  // Defined Class

                Console.WriteLine("Enter new car details below \n \nPlease enter the colour");  //Asking the user to enter what Colour their car is.
                car1.setColour(Console.ReadLine());
                    
                Console.WriteLine("Please enter the make of the car");                //Asking the user to enter what Make their car is.
                car1.setMake(Console.ReadLine());

                Console.WriteLine("Please enter the gear transmission");             //Asking the user to enter what Transmission their car is.
                car1.setGearBox(Console.ReadLine());

                Console.WriteLine();


                Console.WriteLine($"This car is a {car1.getColour()} {car1.getMake()} with a {car1.getGearBox()} transmission"); // Displaying the user's input that was entered and into a sentence.
                Console.WriteLine();

                Console.WriteLine("Thank You and Have a great day");
                Console.ReadLine();
            
        }


        class Car
        {
            
            private string colour;
            private string make;
            private string gearBox;
            

            public string getColour()
            {
                return colour;
            }

            public void setColour(string col)
            {
                colour = col;
            }

            public string getMake()
            {
                return make;
            }

            public void setMake(string mk)
            {
                make = mk;
            }

            public string getGearBox()
            {
                return gearBox;
            }

            public void setGearBox(string gbox)
            {
                gearBox = gbox;
            }

                       
        }
    }
}
