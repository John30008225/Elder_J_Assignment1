using System;

public class Person
{
	
        class Student : Person
    {
        public string Campus { get; set; }
        public int StudentID { get; set; }

        public Student(string _firstName, string _lastName, string _campus)
        {
            FirstName = _firstName;
            LastName = _lastName;
        }

        public int EnrollStudent()                             //Method to return full name
        {
            return _firstName + _lastName + " of " + _campus + " campus has a Student ID of " + StudentID; 
        }

        
    }
}

