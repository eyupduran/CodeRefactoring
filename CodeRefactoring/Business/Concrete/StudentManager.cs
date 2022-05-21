using CodeRefactoring.Business.Abstract;
using CodeRefactoring.Core.Concrete;
using CodeRefactoring.DataAccess.Abstract;
using CodeRefactoring.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeRefactoring.Business.Concrete
{
    public class StudentManager : IStudentService
    {
        IStudentDal _studentDal;
        public StudentManager(IStudentDal studentDal)
        {
            _studentDal = studentDal;
        }
        public void Add(Student student)
        {
            _studentDal.Add(student);
        }

        public List<Student> GetAll()
        {
            return _studentDal.GetAll();
        }
    }
}
