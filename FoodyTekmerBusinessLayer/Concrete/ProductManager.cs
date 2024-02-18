using FoodyTekmerBusinessLayer.Abstract;
using FoodyTekmerDataAccessLayer.Abstract;
using FoodyTekmerEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodyTekmerBusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public void TAdd(Product entity)
        {
            if (entity.Name != "" && entity.Name.Length >= 3 && entity.NewPrice > 0)
            {
                _productDal.Add(entity);
            }
            else
            {
                //hata mesajı
            }
        }
        public void TDelete(int id)
        {
            _productDal.Delete(id);
        }
        public List<Product> TGetAllList()
        {
           return _productDal.GetAllList();
        }

        public Product TGetById(int id)
        {
           return _productDal.GetById(id);
        }

        public void TUpdate(Product entity)
        {
            _productDal.Update(entity);
        }
    }
}
