using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InOut.Models;
using Microsoft.EntityFrameworkCore;

namespace InOut.Controllers
{
    public class ItemController : Controller
    {
        private readonly ItemsExpensesDbContext _db;
        public ItemController(ItemsExpensesDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Item> obj = _db.Items;
            return View(obj);
        }
        //Create Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Item item)
        {
           
            _db.Items.Add(item);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }
      //Create Get
        public IActionResult Create()
        {
            return View();
        }

        //Update GET
        public IActionResult Update(int?id)
        {
            var obj = _db.Items.Find(id);
           

            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Item obj)
        {
            if(obj==null)
            {
                return NotFound();
            }
            _db.Items.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }
        //Get Delete
        public IActionResult Delete(int? id)
        {
            var obj = _db.Items.Find(id);
           
            return View(obj);
        }
        //Post Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.Items.Find(id);
         
            _db.Items.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }

    }
}
