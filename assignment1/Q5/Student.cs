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
        public int StdId { get; set; }

        public Student(string _fname, string _lname, string _camp) : base(_fname, _lname)          //Constructor creating new student record 
        {
           
            Campus = _camp;
            StdId = EnrollStudent();

        }


        public int EnrollStudent()
        {
            Random randm = new Random();
                int rand_num = randm.Next(1000, 9999);          //Random StudentID number Generator for StudentID
                return rand_num;

        }                       
        
               
    }
}
