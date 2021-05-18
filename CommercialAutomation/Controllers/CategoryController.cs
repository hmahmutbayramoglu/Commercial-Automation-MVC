using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CommercialAutomation.Models.Classes;

namespace CommercialAutomation.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        Context context = new Context();
        public ActionResult Index()
        {
            var result = context.Categories.ToList();
            return View(result);
        }

        [HttpGet]
        public ActionResult AddCategoryView()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCategoryView(Category category)
        {
            context.Categories.Add(category);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult Delete(int id)
        {
            var searchCategory = context.Categories.Find(id);

            context.Categories.Remove(searchCategory);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult Get(int id)
        {
            var searchCategory = context.Categories.Find(id);
            return View("CategoryDetails", searchCategory);
        }


        [HttpPost]
        public ActionResult Update(Category category)
        {
            var searchCategory = context.Categories.Find(category.Id);

            searchCategory.Name = category.Name;
            context.SaveChanges();
            return RedirectToAction("Index");
        }




    }
}