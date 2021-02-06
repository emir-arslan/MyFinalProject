using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //generic constraint -- Generic Kısıtlama
    //T:class --> referans tip olabilir demek class olacak demek değildir.
    //IEntity : IEntity olabilir veya implemente eden bir nesne olabilir demektir.
    //new() : 
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null); //Expression kullanımı istediğimiz id ye göre filtreleme yapmak için Kullanırız.
        T Get(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
