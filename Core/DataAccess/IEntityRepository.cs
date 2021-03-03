using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

//CORE KATMANI DİĞER KATMANLARI REFERANS ALMAZ. ALIRSA BAĞIMLI OLUR.

namespace Core.DataAccess
{
    //generic constraint
    //new():newlenebilir olmalı demek
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
