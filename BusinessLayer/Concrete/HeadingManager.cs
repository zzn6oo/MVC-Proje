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
    public class HeadingManager : IHeadingService
    {
        IHeadingDal _headingDal;
        public HeadingManager(IHeadingDal headingDal)
        {
            _headingDal = headingDal;
        }
        public void addHeading(Heading param)
        {
            throw new NotImplementedException();
        }

        public void deleteHeading(Heading param)
        {
            throw new NotImplementedException();
        }

        public Heading getByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Heading> getList()
        {
            return _headingDal.List();
        }
        public List<Heading> filteredList(List<Heading> param,string filter)
        {
            return param.Where(x => x.Category.CategoryName == filter).ToList();
        }
      
        public void updateHeading(Heading param)
        {
            throw new NotImplementedException();
        }
    }
}
