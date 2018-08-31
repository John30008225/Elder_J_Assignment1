﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Title:   Q5 - Student (Assignment 1A)
Author:     John Elder
Date:       17/08/2018
Purpose:    Adding a second class called Student 
*/
namespace Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Person> persons = new List<Person>();              //List holding strings
            string input = "";

            do
            {      
                Person person1 = new Person("",""); 
                person1 = GetDeets(person1);
                persons.Add(person1);

                Console.Write("\n Do you want to add another person? (y/n)");
                input = Console.ReadLine();
            }while (input == "y");    

            foreach(Person x in persons)
                Console.WriteLine($"Person:" + x.FirstName + x.LastName + "is" + x.GetAge()); 

            Console.WriteLine("Thank You and Have a great day");
            Console.ReadLine();
        }


        public static Person GetDeets (Person p1)
        {
            Console.WriteLine("Enter name of new person below \n \nFirst name: ");  
            p1.FirstName = Console.ReadLine();
                    
            Console.WriteLine("Last name: ");                                    
            p1.LastName = Console.ReadLine();

            Console.WriteLine("\n Enter year of birth: ");             
            p1.YearOfBirth = int.Parse (Console.ReadLine());
            return p1;
        }
    }   
    
    class Person
    {
     
        public string FirstName { get; set; }                   //The auto-implemented properties
        public string LastName { get; set; }
        public int YearOfBirth { get; set; }

        public Person(string _fname, string _lname)             //Constructor creating new person record
        {
            FirstName = _fname;
            LastName = _lname;
        } 
               
        public string GetFullName()                             //Method to return full name
        {
            return FirstName + LastName;                    
        }
                       
        public int GetAge()                               //Method to return full name
        {
            return 2018 - YearOfBirth;                      
        }

    }
} 
  
    
    

  

