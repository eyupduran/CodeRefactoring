using CodeRefactoring.Core.Abstract;
using CodeRefactoring.Entities.Abstract;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CodeRefactoring.Core.Concrete
{
    public class EntityRepositoryBase<TEntity> : IEntityRepository<TEntity>
         
    {
        List<TEntity> myAL;

        public EntityRepositoryBase()
        {
            myAL = new List<TEntity>();
        }

        public void Add(TEntity entity)
        {
            myAL.Add(entity);
        }

        public List<TEntity> GetAll()
        {
            return myAL;
        }
    }
}
