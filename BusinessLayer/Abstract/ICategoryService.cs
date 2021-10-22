using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        List<Category> getList();
        Category getByID(int id);
        void addCategory(Category param);
        void deleteCategory(Category param);
        void updateCategory(Category param);
    }
}
