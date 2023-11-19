using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concretes.InMemory;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class ProductManager : IProductService
    {
        //Somut sınıf inject yapmıyoruz, IProductDal bütün yapıları zaten tutuyor(InMemory,EntityFramework)
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            //Run Rules
            return _productDal.GetAll();
        }
    }
}
