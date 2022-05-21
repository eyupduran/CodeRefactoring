using CodeRefactoring.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeRefactoring.Core.Abstract
{
    public interface IEntityRepository<T>
    {
        void Add(T entity);
        List<T> GetAll();

    }
}
