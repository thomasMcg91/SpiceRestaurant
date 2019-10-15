using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Spice.Data;
using Spice.Models;
using Spice.Models.ViewModels;
using Spice.Utility;

namespace Spice.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MenuItemController : Controller
    {
        private readonly ApplicationDbContext _db;
        //for adding images to the server below
        private readonly IHostingEnvironment _hostingEnvironment;

        [BindProperty]
        public MenuItemViewModel menuItemVW { get; set; }

        public MenuItemController(ApplicationDbContext db, IHostingEnvironment hostingEnvironment)
        {
            _db = db;
            _hostingEnvironment = hostingEnvironment;
            menuItemVW = new MenuItemViewModel()
            {
                Category = _db.Category,
                MenuItem = new MenuItem()
            };
        }

        public async Task <IActionResult> Index()
        {
            var menu = await _db.MenuItem.Include(m=> m.Category).Include(m=> m.SubCategory).ToListAsync();
            return View(menu);         
        }

        //get create
        public IActionResult Create()
        {
            return View(menuItemVW);
        }

        //create post
        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatePOST()
        {
            menuItemVW.MenuItem.SubCategoryId = Convert.ToInt32(Request.Form["SubCategoryId"].ToString());

            if (!ModelState.IsValid)
            {
                return View(menuItemVW);
            }
            _db.MenuItem.Add(menuItemVW.MenuItem);
            await _db.SaveChangesAsync();

            //work on image saving section 
            string webRootPath = _hostingEnvironment.WebRootPath;
            var files = HttpContext.Request.Form.Files;

            var menuItemFromDb = await _db.MenuItem.FindAsync(menuItemVW.MenuItem.Id);

            if (files.Count > 0)
            {
                //files has been uploaded
                var uploads = Path.Combine(webRootPath, "images");
                var extension = Path.GetExtension(files[0].FileName);

                using (var filesStream = new FileStream(Path.Combine(uploads, menuItemVW.MenuItem.Id + extension), FileMode.Create))
                {
                    files[0].CopyTo(filesStream);
                }
                menuItemFromDb.Image = @"\images\" + menuItemVW.MenuItem.Id + extension;
            }
            else
            {
                //no file was uploaded, so use default
                var uploads = Path.Combine(webRootPath, @"images\" + SD.DefaultFoodImage);
                System.IO.File.Copy(uploads, webRootPath + @"\images\" + menuItemVW.MenuItem.Id + ".png");
                menuItemFromDb.Image = @"\images\" + menuItemVW.MenuItem.Id + ".png";
            }

            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));

        }
        
    }
}