using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using MVCProje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProje.Controllers
{
    public class StatisticsController : Controller
    {
        //1) Toplam kategori sayısı +
        //2) Başlık tablosunda "yazılım" kategorisine ait başlık sayısı (filtre)
        //3) Yazar adında 'a' harfi geçen yazar sayısı (Author sınıfı oluşturmak gerekiyor)
        //4) En fazla başlığa sahip kategori adı (filtre)
        //5) Kategori tablosunda durumu true olan kategoriler ile false olan kategoriler arasındaki sayısal fark (filtre)
        // GET: Statistics
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        AuthorManager am = new AuthorManager(new EfAboutDal());
        HeadingManager hm = new HeadingManager(new EfHeadingDal());
        public ActionResult Index()
        {
            Statistics model = new Statistics();
            List<Author> authors = new List<Author>();
            List<Category> categories = new List<Category>();
            List<Heading> headings = new List<Heading>();

            categories = cm.getList();
            authors = am.getList();
            headings = hm.getList();
            //1
            var categoryCount = categories.Count; //Count of number of categories
            //2
            headings = hm.filteredList(headings, "Yazılım");
            var headingCount = headings.Count(); //Count of headings under Yazılım category
            //3
            authors = am.filteredList(authors, "a");
            var authorCount = authors.Count(); //Count of author with letter a,A in it
            //4
            headings = hm.getList();
            int id = headings.GroupBy(x => x.CategoryID).OrderByDescending(y => y.Count()).Select(z => z.Key).FirstOrDefault();
            var mostrepeated = cm.getByID(id).CategoryName; //Name of the category with most headings
            //5
            var activeCount = cm.filteredList(categories, true).Count;
            var passiveCount = categories.Count - activeCount;
            var diff = Math.Abs(activeCount - passiveCount); //Difference between counts of active and passive categories (ABS to eliminate negative results)

            model.categoryCount = categoryCount;
            model.headingCount = headingCount;
            model.authorCount = authorCount;
            model.categoryWithMostHeadings = mostrepeated;
            model.diff = diff;

           


            return View(model);
        }
    }
}