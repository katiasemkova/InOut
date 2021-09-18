using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InOut.Controllers
{
    public class ExpenseTypeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
