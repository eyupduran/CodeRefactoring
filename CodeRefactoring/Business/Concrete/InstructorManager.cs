using CodeRefactoring.Business.Abstract;
using CodeRefactoring.DataAccess.Abstract;
using CodeRefactoring.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeRefactoring.Business.Concrete
{
    public class InstructorManager : IInstructorService
    {
       private IInstructorDal _ınstructorDal;
        public InstructorManager(IInstructorDal ınstructorDal)
        {
            _ınstructorDal = ınstructorDal;
        }
        public void Add(Instructor ınstructor)
        {
            _ınstructorDal.Add(ınstructor);
        }

        public List<Instructor> GetAll()
        {
          return _ınstructorDal.GetAll();
        }
    }
}
