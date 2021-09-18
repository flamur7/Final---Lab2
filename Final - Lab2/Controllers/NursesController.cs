using Final___Lab2.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final___Lab2.Controllers
{
    
    public class NursesController : Controller
    {
        private readonly ApplicationDbContext _db;
        [BindProperty]
        public Nurse Nurse { get; set; }
        public NursesController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Upsert(int? id)
        {
            Nurse = new Nurse();
            if (id == null)
            {
                //create
                return View(Nurse);
            }
            //update
            Nurse = _db.Nurses.FirstOrDefault(u => u.Id == id);
            if (Nurse == null)
            {
                return NotFound();
            }
            return View(Nurse);
        }

        public IActionResult Detail(int? id)
        {
            Nurse = new Nurse();
            if (id == null)
            {
                //create
                return View(Nurse);
            }
            //update
            Nurse = _db.Nurses.FirstOrDefault(u => u.Id == id);
            if (Nurse == null)
            {
                return NotFound();
            }
            return View(Nurse);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert()
        {
            if (ModelState.IsValid)
            {
                if (Nurse.Id == 0)
                {
                    //create
                    _db.Nurses.Add(Nurse);
                }
                else
                {
                    _db.Nurses.Update(Nurse);
                }
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(Nurse);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Detail()
        {
            if (ModelState.IsValid)
            {
                if (Nurse.Id == 0)
                {
                    //create
                    _db.Nurses.Add(Nurse);
                }
                else
                {
                    _db.Nurses.Update(Nurse);
                }
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(Nurse);
        }



        #region API Calls
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Json(new { data = await _db.Nurses.ToListAsync() });
        }


        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var nurseFromDb = await _db.Nurses.FirstOrDefaultAsync(u => u.Id == id);
            if (nurseFromDb == null)
            {
                return Json(new { success = false, message = "Error while Deleting" });
            }
            _db.Nurses.Remove(nurseFromDb);
            await _db.SaveChangesAsync();
            return Json(new { success = true, message = "Delete successful" });
        }
        #endregion
    }
}
