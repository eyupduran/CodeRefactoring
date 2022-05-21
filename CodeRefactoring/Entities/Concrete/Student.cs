using System;
using System.Collections.Generic;
using System.Text;

namespace CodeRefactoring.Entities.Concrete
{
    public class Student : User
    {
        public string SchoolName { get; set; }
        public string[] Instructors { get; set; }
        public string[] Lessons { get; set; }

        public Student(string FirstName, string LastName, string Email, string Password,
            string schoolName, string[] ınstructors, string[] lessons)
            : base(FirstName, LastName, Email, Password)
        {
            SchoolName = schoolName;
            Instructors = ınstructors;
            Lessons = lessons;
        }


    }      

 }

