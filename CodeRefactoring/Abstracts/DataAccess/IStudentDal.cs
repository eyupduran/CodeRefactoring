using CodeRefactoring.Core.Abstract;
using CodeRefactoring.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeRefactoring.DataAccess.Abstract
{
    public interface IStudentDal:IEntityRepository<Student>
    {
    }
}
