using FoodyTekmerDataAccessLayer.Abstract;
using FoodyTekmerDataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodyTekmerDataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        FoodyContext context = new FoodyContext();
        public void Add(T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            var value = context.Set<T>().Find(id);
            context.Set<T>().Remove(value);
            context.SaveChanges();
        }
        public List<T> GetAllList()
        {
            return context.Set<T>().ToList();
        }
        public T GetById(int id)
        {
            return context.Set<T>().Find(id);
        }
        public void Update(T entity)
        {
            context.Set<T>().Update(entity);
            context.SaveChanges();
        }
    }
}
