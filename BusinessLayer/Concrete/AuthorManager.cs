using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AuthorManager : IAuthorService
    {
        IAuthorDal _authorDal;
        public AuthorManager(IAuthorDal authorDal)
        {
            _authorDal = authorDal;
        }

        public List<Author> getList()
        {
            return _authorDal.List();
        }
        public List<Author> filteredList(List<Author> param,string filter)
        {
            return param.Where(x => x.AuthorName.Contains(filter.ToLower()) || x.AuthorName.Contains(filter.ToUpper())).ToList();
        }

        public Author getByID(int id)
        {
            throw new NotImplementedException();
        }

        public void addAuthor(Author param)
        {
            throw new NotImplementedException();
        }

        public void deleteAuthor(Author param)
        {
            throw new NotImplementedException();
        }

        public void updateAuthor(Author param)
        {
            throw new NotImplementedException();
        }
    }
}
