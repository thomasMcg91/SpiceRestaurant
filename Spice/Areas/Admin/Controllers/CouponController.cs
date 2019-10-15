using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Spice.Data;
using Spice.Models;

namespace Spice.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CouponController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CouponController(ApplicationDbContext db)
        {
            _db = db;
        }


        public async Task <IActionResult> Index()
        {
            return View( await _db.Coupon.ToListAsync());
        }

        //get create
        public IActionResult Create()
        {
            return View();
        }

        //post create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task <IActionResult> Create (Coupon coupon)
        {
            if (ModelState.IsValid)
            {
                var files = HttpContext.Request.Form.Files;
                if (files.Count > 0)
                {
                    byte[] p1 = null;
                    using (var fs1 = files[0].OpenReadStream())
                    {
                        using (var ms1 = new MemoryStream())
                        {
                            fs1.CopyTo(ms1);
                            p1 = ms1.ToArray();
                        }
                    }
                    coupon.Picture = p1;
                }
                _db.Coupon.Add(coupon);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(coupon);
        }
            
        //get edit
        public async Task <IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var t = await _db.Coupon.FindAsync(id);
            return View(t);
        }

        //post create
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPOST(Coupon coupon)
        {
           if (coupon.Id == 0)
            {
                return NotFound();
            }

            Coupon couponFromDb = await _db.Coupon.FindAsync(coupon.Id);

            if (!ModelState.IsValid)
            {

                return View(coupon);
            }

            var files = HttpContext.Request.Form.Files;
            if (files.Any())
            {
                byte[] p1 = null;
                //convert image to binary and store it

                using (var fs1 = files[0].OpenReadStream())
                {
                    using (var ms1 = new MemoryStream())
                    {
                        fs1.CopyTo(ms1);
                        p1 = ms1.ToArray();
                    }
                }

                couponFromDb.Picture = p1;
            }

            couponFromDb.Name = coupon.Name;
            couponFromDb.CouponType = coupon.CouponType;
            couponFromDb.Discount = coupon.Discount;
            couponFromDb.IsActive = coupon.IsActive;
            couponFromDb.MinimumAmout = coupon.MinimumAmout;



            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


        //GET - Details
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Coupon couponFromDb = await _db.Coupon.FindAsync(id);

            return View(couponFromDb);
        }

        //GET - DELETE
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            return View(await _db.Coupon.FindAsync(id));
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
             _db.Coupon.Remove(await _db.Coupon.FindAsync(id));
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
    }


}