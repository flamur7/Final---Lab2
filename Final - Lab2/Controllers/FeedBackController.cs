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
    public class FeedBackController : Controller
    {
        private readonly ApplicationDbContext _context;



        public FeedBackController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<FeedBack> feedBacks;
            feedBacks = _context.FeedBacks.ToList();
            return View(feedBacks);
        }
        [HttpGet]
        public IActionResult Create()
        {
            FeedBack feedBack = new FeedBack();

            feedBack.Detajets.Add(new Detajet() { DetajetId = 1 });
            feedBack.Detajets.Add(new Detajet() { DetajetId = 1 });
            feedBack.Detajets.Add(new Detajet() { DetajetId = 1 });

            return View(feedBack);
        }

        [HttpPost]
        public IActionResult Create(FeedBack feedBack)
        {

            _context.Add(feedBack);
            _context.SaveChanges();
            return RedirectToAction("index");
        }

       [HttpGet]
       public IActionResult Edit(int Id)
        {
            FeedBack feedBack = _context.FeedBacks.Where(p => p.FeedBackId == Id).FirstOrDefault();
            return View(feedBack);
        }
        [HttpPost]
        public IActionResult Edit (FeedBack feedBack)
        {
            _context.Attach(feedBack);
            _context.Entry(feedBack).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("index");
        }

        //[HttpGet]
        //public IActionResult Delete(int Id)
        //{
        //    FeedBack feedBack = _context.FeedBacks
        //        .Include(p =>p.Detajets)
        //        .Where(p => p.FeedBackId == Id).FirstOrDefault();
        //    return View(feedBack);
        //}
        //[HttpPost]
        //public IActionResult Delete(FeedBack feedBack)
        //{
            
            

        //    _context.Attach(feedBack);
        //    _context.Entry(feedBack).State = EntityState.Deleted;
        //    _context.SaveChanges();
        //    return RedirectToAction("index");
        //}



    }
}
