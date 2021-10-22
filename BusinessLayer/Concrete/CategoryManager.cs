using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void addCategory(Category param)
        {
            _categoryDal.Insert(param);
        }

        public void deleteCategory(Category param)
        {
            _categoryDal.Delete(param);
        }

        public void updateCategory(Category param)
        {
            _categoryDal.Update(param);
        }

        public Category getByID(int id)
        {
            return _categoryDal.Get(x => x.CategoryID == id);
        }

        public List<Category> getList()
        {
            return _categoryDal.List();
        }
        public List<Category> filteredList(List<Category> param, bool filter)
        {
            return param.Where(x => x.CategoryStatus == filter).ToList();
        }
       

    }
}

#region Comments
//GenericRepository<Category> genericRepository = new GenericRepository<Category>();


//public List<Category> FetchAll()
//{
//    return genericRepository.List();
//}
//public void CategoryAdd(Category param)
//{
//    if (
//        param.CategoryName == "" ||
//        param.CategoryName.Length <= 3 ||
//        param.CategoryDescription == "" ||
//        param.CategoryName.Length >= 51)
//    {
//        // Hata mesajı
//    }
//    else
//    {
//        genericRepository.Insert(param);
//    }
//}
#endregion