﻿using Final___Lab2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace Final___Lab2.Controllers
{
    public class PacientController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _webHost;


        public PacientController(ApplicationDbContext context, IWebHostEnvironment webHost)
        {
            _context = context;
            _webHost = webHost;

        }
        public IActionResult Index()
        {
            List<Pacient> pacients;
            pacients = _context.Pacients.ToList();
            return View(pacients);
        }
        [HttpGet]
        public IActionResult Create()
        {
            Pacient pacient = new Pacient();

            
            pacient.Terapis.Add(new Terapi() { TerapiId = 1 });
            pacient.Terapis.Add(new Terapi() { TerapiId = 2 });
            pacient.Terapis.Add(new Terapi() { TerapiId = 3 });

            return View(pacient);
        }

        [HttpPost]
        public IActionResult Create(Pacient pacient)
        {

            string uniqueFileName = GetUploadedFileName(pacient);
            pacient.PhotoUrl = uniqueFileName;

            _context.Add(pacient);
            _context.SaveChanges();
            return RedirectToAction("index");
        }

        private string GetUploadedFileName(Pacient pacient)
        {
            string uniqueFileName = null;

            if (pacient.ProfilePhoto != null)
            {
                string uploadsFolder = Path.Combine(_webHost.WebRootPath, "lib");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + pacient.ProfilePhoto.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    pacient.ProfilePhoto.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }
    }
}
