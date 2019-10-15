using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Spice.Data;
using Spice.Models;

namespace Spice.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        //GET 
        public async Task <IActionResult> Index()
        {
            return View(await _db.Category.ToListAsync());
        }

        //not async as not passing anything to the view
        public IActionResult Create()
        {
            return View();
        }

        //Create post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create (Category category)
        {
            if (ModelState.IsValid)
            {
                _db.Category.Add(category);
               await  _db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        //details get
        public async Task<IActionResult> Details(int? id)
        {
            var cat = await _db.Category.FindAsync(id);
            if (cat == null)
            {
                return NotFound();
            }
            return View(cat);

        }

        //EDIT get
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var cat = await _db.Category.FindAsync(id);
            if (cat == null)
            {
                return NotFound();
            }
            return View(cat);

        }

        //EDIT POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit (Category category)
        {
            if (ModelState.IsValid)
            {
                _db.Update(category);
                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        //get delete
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var t = await _db.Category.FindAsync(id);
            if(t == null)
            {
                return NotFound();
            }
            return View(await _db.Category.FindAsync(id));
        }

        //delete post
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirm(int id)
        {

            var y = await _db.Category.FindAsync(id);
            if (y == null)
            {
                return NotFound();
            }
            _db.Category.Remove(y);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
            
        }
    }
}