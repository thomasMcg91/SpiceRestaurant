using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Spice.Data;
using Spice.Models;
using Spice.Models.ViewModels;

namespace Spice.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SubCategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        [TempData]
        public string statusMessage { get; set; }

        public SubCategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            var subCategory = await _db.SubCategory.Include(s => s.Category).ToListAsync();
            return View(subCategory);

        }

        //create get
        public async Task<IActionResult> Create()
        {
            SubCategoryAndCategoryViewModel model = new SubCategoryAndCategoryViewModel()
            {
                CategoryList = await _db.Category.ToListAsync(),
                SubCategory = new Models.SubCategory(),
                SubCategoryList = await _db.SubCategory.OrderBy(s => s.Name).Select(d => d.Name).Distinct().ToListAsync()
            };
            return View(model);
        }

        //Post create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create (SubCategoryAndCategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                var subCategoryExists = _db.SubCategory.Include(s => s.Category).Where(s => s.Name == model.SubCategory.Name && s.Category.Id == model.SubCategory.CategoryId);

                if (subCategoryExists.Count() > 0)
                {
                    statusMessage = "Error : sub category exists under" + subCategoryExists.First().Category.Name + " please select another category";   
                }
                else if (subCategoryExists.Count() == 0)
                {
                    _db.SubCategory.Add(model.SubCategory);
                    await _db.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            SubCategoryAndCategoryViewModel modelVm = new SubCategoryAndCategoryViewModel()
            {
                CategoryList = await _db.Category.ToListAsync(),
                SubCategory = new SubCategory(),
                SubCategoryList = await _db.SubCategory.OrderBy(s => s.Name).Select(d => d.Name).ToListAsync(),
                StatusMessage = statusMessage
            };
            return View(modelVm);
        }

        [ActionName("GetSubCategory")]
        public async Task<IActionResult> GetSubCategory (int id)
        {
            List<SubCategory> subCategories = new List<SubCategory>();

            subCategories = await (from subCategory in _db.SubCategory
                                   where subCategory.CategoryId == id
                                   select subCategory).ToListAsync();
            return Json(new SelectList(subCategories, "Id", "Name"));
            
        }

        //create edit
        public async Task<IActionResult> Edit(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var subCategory = await _db.SubCategory.SingleOrDefaultAsync(m => m.Id == id);

            if (subCategory == null)
            {
                return NotFound();
            }

            SubCategoryAndCategoryViewModel model = new SubCategoryAndCategoryViewModel()
            {
                CategoryList = await _db.Category.ToListAsync(),
                SubCategory = subCategory,
                SubCategoryList = await _db.SubCategory.OrderBy(s => s.Name).Select(d => d.Name).Distinct().ToListAsync()
            };
            return View(model);
        }

        //Post edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, SubCategoryAndCategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                var subCategoryExists = _db.SubCategory.Include(s => s.Category).Where(s => s.Name == model.SubCategory.Name && s.Category.Id == model.SubCategory.CategoryId);

                if (subCategoryExists.Count() > 0)
                {
                    statusMessage = "Error : sub category exists under" + subCategoryExists.First().Category.Name + " please select another category";
                }
                else 
                {
                    var subCat = await _db.SubCategory.FindAsync(id);
                    subCat.Name = model.SubCategory.Name;
                   
                    await _db.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            SubCategoryAndCategoryViewModel modelVm = new SubCategoryAndCategoryViewModel()
            {
                CategoryList = await _db.Category.ToListAsync(),
                SubCategory = new SubCategory(),
                SubCategoryList = await _db.SubCategory.OrderBy(s => s.Name).Select(d => d.Name).ToListAsync(),
                StatusMessage = statusMessage
            };
            return View(modelVm);
        }

        //details get
        public async Task <IActionResult> Details(int? id)
        {
            var item = await _db.SubCategory.FindAsync(id);

            if (item == null)
            {
                return NotFound();
            }
          

                return View(item);         
        }

        //delete get
        public async Task<IActionResult> Delete (int? id)
        {
           
            if (id == null)
            {
                return NotFound();
            }

            var subCategory = await _db.SubCategory.Include(s => s.Category).Where(s => s.Id == id).FirstAsync();
            if (subCategory == null)
            {
                return NotFound();
            }

            return View(subCategory);

        }

        //Delete post
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task <IActionResult> DeleteConfirm(int id)
        {
            var item = await _db.SubCategory.FindAsync(id);
            if (item == null)
            {
                return NotFound();
            }
            _db.Remove(item);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }

    

   
}