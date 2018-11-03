using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppCuaToi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AppCuaToi.Controllers
{
    public class CategoryController : Controller
    {
        private readonly MyDataContext _context;

        public CategoryController(MyDataContext context)
        {
            _context = context;
        }

        public IActionResult Detail(long id)
        {
            var category = _context.Categories.Include(c => c.ListProduct).SingleOrDefault(c => c.id == id);
            if(category == null)
            {
                return NotFound();
            }
            return View(category);
        }
    }
}