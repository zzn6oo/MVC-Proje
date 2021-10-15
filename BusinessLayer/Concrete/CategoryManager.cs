using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> genericRepository = new GenericRepository<Category>();
        public List<Category> FetchAll()
        {
            return genericRepository.List();
        }
        public void CategoryAdd(Category param)
        {
            if(
                param.CategoryName == "" || 
                param.CategoryName.Length <=3 || 
                param.CategoryDescription == "" || 
                param.CategoryName.Length >=51)
            {
                // Hata mesajı
            }
            else
            {
                genericRepository.Insert(param);
            }
        }
    }
}
