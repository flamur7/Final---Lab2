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
    [Authorize]
    public class ReceptionistsController : Controller
    {
        private readonly ApplicationDbContext _db;
        [BindProperty]
        public Receptionist Receptionist { get; set; }
        public ReceptionistsController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Upsert(int? id)
        {
            Receptionist = new Receptionist();
            if (id == null)
            {
                //create
                return View(Receptionist);
            }
            //update
            Receptionist = _db.Receptionists.FirstOrDefault(u => u.Id == id);
            if (Receptionist == null)
            {
                return NotFound();
            }
            return View(Receptionist);
        }

        public IActionResult Detail(int? id)
        {
            Receptionist = new Receptionist();
            if (id == null)
            {
                //create
                return View(Receptionist);
            }
            //update
            Receptionist = _db.Receptionists.FirstOrDefault(u => u.Id == id);
            if (Receptionist == null)
            {
                return NotFound();
            }
            return View(Receptionist);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert()
        {
            if (ModelState.IsValid)
            {
                if (Receptionist.Id == 0)
                {
                    //create
                    _db.Receptionists.Add(Receptionist);
                }
                else
                {
                    _db.Receptionists.Update(Receptionist);
                }
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(Receptionist);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Detail()
        {
            if (ModelState.IsValid)
            {
                if (Receptionist.Id == 0)
                {
                    //create
                    _db.Receptionists.Add(Receptionist);
                }
                else
                {
                    _db.Receptionists.Update(Receptionist);
                }
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(Receptionist);
        }



        #region API Calls
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Json(new { data = await _db.Receptionists.ToListAsync() });
        }


        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var receptionistFromDb = await _db.Receptionists.FirstOrDefaultAsync(u => u.Id == id);
            if (receptionistFromDb == null)
            {
                return Json(new { success = false, message = "Error while Deleting" });
            }
            _db.Receptionists.Remove(receptionistFromDb);
            await _db.SaveChangesAsync();
            return Json(new { success = true, message = "Delete successful" });
        }
        #endregion
    }
}
