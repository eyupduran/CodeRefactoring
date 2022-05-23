using CodeRefactoring.Business.Concrete;
using CodeRefactoring.DataAccess.Concrete.InMemory;
using CodeRefactoring.Entities.Concrete;
using System;

namespace CodeRefactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            //Testing student
            StudentManager studentManager = new StudentManager(new StudentDal());
            string[] instructorsArray = new string[] { "Engin", "Alper" };
            string[] lessonsArray = new string[] { "Yazılım Mühendisliği", "Mikroişlemci" };

            Student student = new Student("Eyüp","Duran", "ed@gmail.com", "123","pau",instructorsArray,lessonsArray);
            studentManager.Add(student);

            foreach (var item in studentManager.GetAll())
            {
                Console.WriteLine(item.FirstName);
                Console.WriteLine(item.Lessons[0]);

            }

            Console.WriteLine("----------------------------------------------------");
            //Testing instructor

            InstructorManager ınstructorManager = new InstructorManager(new InstructorDal());
            string[] coursesArray = new string[] { "C#", "Java" };
            string[] studentsArray = new string[] { "Eyüp", "Fatih" };

            Instructor ınstructor  = new Instructor("Can ", "Değer", "c@gmail.com", "12223",coursesArray,studentsArray);
            ınstructorManager.Add(ınstructor);

            foreach (var item in ınstructorManager.GetAll())
            {
                Console.WriteLine(item.FirstName);

                foreach (var course in item.Courses)
                {
                    Console.WriteLine(course);
                }

            }


        }
    }
}
