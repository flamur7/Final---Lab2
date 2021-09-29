using Final___Lab2.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final___Lab2.Controllers
{
    [Authorize(Roles = "Admin,Doctor,User,Nurses,Receotionist")]
    public class AppointmentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AppointmentController(ApplicationDbContext context, IWebHostEnvironment webHost)
        {
            _context = context;
           

        }
        public IActionResult Index()
        {
            List<Appointment> appointments;
            appointments = _context.Appointments.ToList();
            return View(appointments);
        }

        
    }
}
