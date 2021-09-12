using Final___Lab2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final___Lab2.Controllers
{
    public class DoctorsController : Controller
    {
        private readonly ApplicationDbContext _db;
        [BindProperty]
        public Doctor Doctor { get; set; }
        public DoctorsController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Upsert(int? id)
        {
            Doctor = new Doctor();
            if (id == null)
            {
                //create
                return View(Doctor);
            }
            //update
            Doctor = _db.Doctors.FirstOrDefault(u => u.Id == id);
            if (Doctor == null)
            {
                return NotFound();
            }
            return View(Doctor);
        }

        public IActionResult Detail(int? id)
        {
            Doctor = new Doctor();
            if (id == null)
            {
                //create
                return View(Doctor);
            }
            //update
            Doctor = _db.Doctors.FirstOrDefault(u => u.Id == id);
            if (Doctor == null)
            {
                return NotFound();
            }
            return View(Doctor);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert()
        {
            if (ModelState.IsValid)
            {
                if (Doctor.Id == 0)
                {
                    //create
                    _db.Doctors.Add(Doctor);
                }
                else
                {
                    _db.Doctors.Update(Doctor);
                }
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(Doctor);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Detail()
        {
            if (ModelState.IsValid)
            {
                if (Doctor.Id == 0)
                {
                    //create
                    _db.Doctors.Add(Doctor);
                }
                else
                {
                    _db.Doctors.Update(Doctor);
                }
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(Doctor);
        }



        #region API Calls
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Json(new { data = await _db.Doctors.ToListAsync() });
        }


        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var doctorFromDb = await _db.Doctors.FirstOrDefaultAsync(u => u.Id == id);
            if (doctorFromDb == null)
            {
                return Json(new { success = false, message = "Error while Deleting" });
            }
            _db.Doctors.Remove(doctorFromDb);
            await _db.SaveChangesAsync();
            return Json(new { success = true, message = "Delete successful" });
        }
        #endregion
    }
}
