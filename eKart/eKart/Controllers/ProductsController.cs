using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eKart.Models;

namespace eKart.Controllers
{
    public class ProductsController : Controller
    {
        private CartEntity db = new CartEntity();

        //
        // GET: /Products/

        public ActionResult Index()
        {
            return View(db.Products.ToList());
        }

        //
        // GET: /Products/Details/5

        public ActionResult Details(int id = 0)
        {
            Products products = db.Products.Find(id);
            if (products == null)
            {
                return HttpNotFound();
            }
            return View(products);
        }

        //
        // GET: /Products/Create

        public ActionResult Create()
        {
           
            //ViewBag.Category = new SelectList(
            //    db.Categories.ToList(),
            //    "Category_ID",
            //    "Category_Name")
            //    ;
            //ViewBag.Gender = new SelectList(
            //    db.Genders.ToList(),
            //    "Gender_ID",
            //    "Gender_Name"
            //    );
            //return View();
            var model = new Products();
            model.CategoryList = db.Categories.Select(x => new SelectListItem
            {
                Text = x.Category_Name,
                Value = x.Category_Name
            }).ToList();

            model.GenderList = db.Genders.Select(x => new SelectListItem
            {
                Text = x.Gender_Name,
                Value = x.Gender_Name
            }).ToList();

            return View(model);

        }

        //
        // POST: /Products/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Products products)
        {
            if (products.Image.ContentLength > (2 * 1024 * 1024))
            {
                ModelState.AddModelError("CustomError", "The Size of the Image is 2MB");
                return View();
            }
            if (!(products.Image.ContentType == "image/jpeg" || products.Image.ContentType == "image/gif"))
            {
                ModelState.AddModelError("CustomError", "File type allowed : jpeg and gif");
                return View();
            }

            byte[] data = new byte[products.Image.ContentLength];
            products.Image.InputStream.Read(data, 0, products.Image.ContentLength);
            products.Product_Photo = data;

            try
            {
                db.Products.Add(products);
                db.SaveChanges();
                return RedirectToAction("Index");       
            }
            catch
            {
                var model = new Products();
                model.CategoryList = db.Categories.Select(x => new SelectListItem
                {
                    Text = x.Category_Name,
                    Value = x.Category_Name
                }).ToList();

                model.GenderList = db.Genders.Select(x => new SelectListItem
                {
                    Text = x.Gender_Name,
                    Value = x.Gender_Name
                }).ToList();

                return View(products);
            }
        }

        //
        // GET: /Products/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Products products = db.Products.Find(id);
            if (products == null)
            {
                return HttpNotFound();
            }
            return View(products);
        }

        //
        // POST: /Products/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Products products)
        {
            if (ModelState.IsValid)
            {
                db.Entry(products).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(products);
        }

        //
        // GET: /Products/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Products products = db.Products.Find(id);
            if (products == null)
            {
                return HttpNotFound();
            }
            return View(products);
        }

        //
        // POST: /Products/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Products products = db.Products.Find(id);
            db.Products.Remove(products);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}