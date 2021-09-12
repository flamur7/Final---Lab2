using Final___Lab2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final___Lab2.Controllers
{
    public class TechnicalsController : Controller
    {
        private readonly ApplicationDbContext _db;
        [BindProperty]
        public Technical Technical { get; set; }
        public TechnicalsController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Upsert(int? id)
        {
            Technical = new Technical();
            if (id == null)
            {
                //create
                return View(Technical);
            }
            //update
            Technical = _db.Technicals.FirstOrDefault(u => u.Id == id);
            if (Technical == null)
            {
                return NotFound();
            }
            return View(Technical);
        }

        public IActionResult Detail(int? id)
        {
            Technical = new Technical();
            if (id == null)
            {
                //create
                return View(Technical);
            }
            //update
            Technical = _db.Technicals.FirstOrDefault(u => u.Id == id);
            if (Technical == null)
            {
                return NotFound();
            }
            return View(Technical);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert()
        {
            if (ModelState.IsValid)
            {
                if (Technical.Id == 0)
                {
                    //create
                    _db.Technicals.Add(Technical);
                }
                else
                {
                    _db.Technicals.Update(Technical);
                }
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(Technical);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Detail()
        {
            if (ModelState.IsValid)
            {
                if (Technical.Id == 0)
                {
                    //create
                    _db.Technicals.Add(Technical);
                }
                else
                {
                    _db.Technicals.Update(Technical);
                }
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(Technical);
        }



        #region API Calls
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Json(new { data = await _db.Technicals.ToListAsync() });
        }


        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var technicalFromDb = await _db.Technicals.FirstOrDefaultAsync(u => u.Id == id);
            if (technicalFromDb == null)
            {
                return Json(new { success = false, message = "Error while Deleting" });
            }
            _db.Technicals.Remove(technicalFromDb);
            await _db.SaveChangesAsync();
            return Json(new { success = true, message = "Delete successful" });
        }
        #endregion
    }
}
