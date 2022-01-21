using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrderManagement.Data;
using OrderManagement.Models;

namespace OrderManagement.Controllers
{
    public class CategoryController : Controller
    {
        public readonly ApplicationDBContext _db;

        public CategoryController(ApplicationDBContext db)
        {
            _db = db; 
        }
        public IActionResult Index()
        {
            IEnumerable<Category> objList = _db.Category;
            return View(objList);
        }
    }
}
