using DataAccess.Abstract;
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class GenericRepository<T> : IGenericDal<T>  where T : class //sadece classların kullanabilmesi için
    {
        public void Add(T entity) 
        {
            using var c = new BlogDbContext(); //db ağır
            c.Add(entity);
            c.SaveChanges();
        }

        public void Update(T entity)
        {
            using var c = new BlogDbContext();
            c.Update(entity);
            c.SaveChanges();
        }

        public void Delete(T entity)
        {
            using var c = new BlogDbContext();
            c.Remove(entity);
            c.SaveChanges(); 
        }

        public List<T> GetAllList()
        {
           using var c = new BlogDbContext();
            return c.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            using var c = new BlogDbContext();
            return c.Set<T>().Find(id);
        }

        public T GetListByFilter(Expression<Func<T, bool>> filter)
        {
            using var c = new BlogDbContext();
            return c.Set<T>().Find(filter);
        }
    }
}
