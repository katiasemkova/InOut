using InOut.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InOut.Controllers
{
    public class ExpenseController : Controller
    {
        private readonly ItemsExpensesDbContext _db;
        public ExpenseController(ItemsExpensesDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Expense> obj = _db.Expenses;
            return View(obj);
        }
        //Get Create
        public IActionResult Create()
        {
            return View();
        }
        //Create Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Expense obj)
        {
            _db.Expenses.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Update(int? id)
        {
            var obj = _db.Expenses.Find(id);
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Expense obj)
        {
         
            _db.Expenses.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    
    public IActionResult Delete(int? id)
    {
        var obj = _db.Expenses.Find(id);
        return View(obj);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult DeletePost(int?id)
    {
         var obj = _db.Expenses.Find(id);
         _db.Expenses.Remove(obj);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }
}
}
