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
    public class ContentController : Controller
    {
        private Blogcontext _context;
        public ContentController(Blogcontext context)
        {
            this._context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Contents.ToList());
        }

        public IActionResult Create()
        {
            ViewBag.Categories = _context.Categories.ToList();
            
            return View();
        }

        [HttpPost]
        public IActionResult Create(Content content)
        {
            ViewBag.Categories = _context.Categories.ToList();

            _context.Contents.Add(content);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            ViewBag.Categories = _context.Categories.ToList();
            var content = _context.Contents.Find(id);
            return View(content);
        }


        [HttpPost]
        public IActionResult Edit(int id, Content model)
        {
            ViewBag.Categories = _context.Categories.ToList();
            _context.Contents.Update(model);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var content = _context.Contents.Find(id);
            return View(content);
        }

        public IActionResult Delete(int id)
        {
            var content = _context.Contents.Find(id);
            _context.Contents.Remove(content);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
        
    }
}
