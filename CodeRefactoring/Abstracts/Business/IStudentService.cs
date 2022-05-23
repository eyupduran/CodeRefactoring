using CodeRefactoring.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeRefactoring.Business.Abstract
{
   public interface IStudentService
    {
        void Add(Student student);
        List<Student> GetAll();

    }
}
