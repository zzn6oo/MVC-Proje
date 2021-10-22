
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProje.Controllers
{
    public class AdminCategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        #region List
        public ActionResult Index()
        {
            var categoryValues = cm.getList();
            return View(categoryValues);
        }
        #endregion
        #region Add
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Category param)
        {
            CategoryValidator categoryValidator = new CategoryValidator();
            ValidationResult validationResult = categoryValidator.Validate(param);
            if(validationResult.IsValid)
            {
                cm.addCategory(param);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
            }
            return View();
        }
        #endregion
        #region Delete
        public ActionResult DeleteCategory(int id)
        {
            var category = cm.getByID(id);
            cm.deleteCategory(category);
            return RedirectToAction("Index");
        }
        #endregion
        #region Update 
        [HttpGet]
        public ActionResult EditCategory(int id)
        {
            var category = cm.getByID(id);
            return View(category);
        }
        [HttpPost]
        public ActionResult EditCategory(Category param)
        {
            cm.updateCategory(param);
            return RedirectToAction("Index");
        }
        #endregion
    }
}