using System;
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

            
            List<Student> students = new List<Student>();              //List holding strings
            string input = "";

            
            do
            {      
                Student student1 = new Student ("","","");            //Loop to create new Student/s
                student1 = GetDeets(student1);
                students.Add(student1);
                

                Console.Write("\n\nDo you want to add another person? (y/n)");
                input = Console.ReadLine();
            }while (input == "y");    

            foreach(Student x in students)                           //For each of the new students display user input of First Name, Last Name, Campus and StudentID in the console
                Console.Write("\n" + x.FirstName + " " + x.LastName + " of " + x.Campus + " has a student ID of " + x.StdId);
                Console.ReadLine();
        }

        

        public static Student GetDeets(Student p1)                  //Asking for user to enter input data
        {

            Console.Write("Enter name of new student below\n\nEnter First name: ");
            p1.FirstName = Console.ReadLine();

            Console.Write("Enter Last name: ");
            p1.LastName = Console.ReadLine();

            Console.Write("Enter Campus: ");
            p1.Campus = Console.ReadLine();

            Console.Write("\nCreating new person record ... ");
            Console.ReadLine();

            Console.Write("\nAdding new student record to "+ p1.Campus +" campus ...");
            Console.ReadLine();

            return p1;

           
        }
    }   
    
    class Person
    {
     
        public string FirstName { get; set; }                      //The auto-implemented properties
        public string LastName { get; set; }
        public int YearOfBirth { get; set; }
        

        public Person(string _fname, string _lname)               //Constructor creating new person record
        {

            FirstName = _fname;


            LastName = _lname;

        } 
               
        public string GetFullName()                               //Method to return full name
        {
            return FirstName + LastName;                    
        }
                       
        public int GetAge()                                      //Method to return age
        {
            return 2018 - YearOfBirth;                      
        }        
                        
    }
} 
  
    
    

  


