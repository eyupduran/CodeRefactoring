using System;
using System.Collections.Generic;
using System.Text;

namespace CodeRefactoring.Entities.Concrete
{
    public class Instructor:User
    {
    
        public string[] Courses { get; set; }
        public string[] Students { get; set; }
        public Instructor(string FirstName, string LastName, string Email, string Password,
       string[] courses, string[] students)
             : base(FirstName, LastName, Email, Password)
        {
            Courses = courses;
            Students = students;
        }
       


    }
}
