using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    class Student : Person                                  //Student class inherited from Person
    { 
    
        public string Campus { get; set; }
        public int StudentID { get; set; }



        public Student(string _camp) : base("","")          //constructor creating new student 
        {
            Campus = _camp;
        }


        public int EnrollStudent()
        {
            Random randm = new Random();
            int rand_num = randm.Next(1000, 9999);          //Random StudentID number Generator
            return rand_num;

        }

        public string GetInfo()
        {
                        
            return FirstName + " " + LastName + " " + " of " + Campus + " Campus " + " has a student ID of " + EnrollStudent();  //Returning user input data
                      
        }

    }
}
