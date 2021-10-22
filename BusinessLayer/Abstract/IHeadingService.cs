using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IHeadingService
    {
        List<Heading> getList();
        Heading getByID(int id);
        void addHeading(Heading param);
        void deleteHeading(Heading param);
        void updateHeading(Heading param);
    }
}
