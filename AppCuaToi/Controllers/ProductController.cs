using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppCuaToi.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppCuaToi.Controllers
{
    public class ProductController : Controller
    {
        private readonly MyDataContext _context;

        public ProductController(MyDataContext context)
        {
            _context = context;
        }
        public IActionResult GetList()
        {
            return View(_context.Products.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Store(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return Redirect("GetList");
        }

        public IActionResult Edit(long id)
        {
            var product = _context.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        public IActionResult Update(Product product)
        {
            var updateProduct = _context.Products.Find(product.id);

            if (updateProduct == null)
            {
                return NotFound();
            }
            updateProduct.name = product.name;
            updateProduct.description = product.description;
            updateProduct.thumbnail = product.thumbnail;
            _context.Products.Update(updateProduct);
            _context.SaveChanges();
            return Redirect("GetList");
        }


        [HttpDelete]
        public IActionResult Delete(long id)
        {
            var product = _context.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            _context.Products.Remove(product);
            _context.SaveChanges();
            return Redirect("GetList");
        }

        [HttpDelete]
        public IActionResult DeleteMany(string ids)
        {
            var stringProductIds = ids.Split(",");

            foreach (var productId in stringProductIds)
            {
                var product = _context.Products.Find(Convert.ToInt64(productId));
                if (product == null)
                {
                    return NotFound();
                }
                _context.Products.Remove(product);
                
            }
            _context.SaveChanges();
            TempData["message"] = "Delete all success";

            return Redirect("GetList");
        }
    }
}