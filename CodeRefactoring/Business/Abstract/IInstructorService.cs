using CodeRefactoring.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeRefactoring.Business.Abstract
{
    public interface IInstructorService
    {
        void Add(Instructor ınstructor);
        List<Instructor> GetAll();
    }
}
