using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BlogPlatform;
using BlogPlatform.Models;

namespace BlogPlatform.Controllers
{
    public class CategoryController : Controller
    {
        private Blogcontext _context;

        public CategoryController(Blogcontext context)
        {
            this._context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Categories.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
           
            _context.Categories.Add(category);
            _context.SaveChanges();

            return RedirectToAction("Index");
            
        }
      
        public IActionResult Edit(int id)
        {
            var category = _context.Categories.Find(id);

            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(int id, Category model)
        {
            _context.Update(model);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var category = _context.Categories.Find(id);
            _context.Categories.Remove(category);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .Include(c => c.Contents)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }
        
    }
}
