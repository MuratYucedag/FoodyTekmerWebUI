using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodyTekmerDataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Add(T entity);
        void Delete(int id);
        void Update(T entity);
        List<T> GetAllList();
        T GetById(int id);
    }
}
