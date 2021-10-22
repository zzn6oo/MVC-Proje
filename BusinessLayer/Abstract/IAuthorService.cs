using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAuthorService
    {
        List<Author> getList();
        Author getByID(int id);
        void addAuthor(Author param);
        void deleteAuthor(Author param);
        void updateAuthor(Author param);
    }
}
