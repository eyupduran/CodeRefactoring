using CodeRefactoring.Core.Concrete;
using CodeRefactoring.DataAccess.Abstract;
using CodeRefactoring.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeRefactoring.DataAccess.Concrete.InMemory
{
   public class StudentDal:EntityRepositoryBase<Student>, IStudentDal
    {
    }
}
