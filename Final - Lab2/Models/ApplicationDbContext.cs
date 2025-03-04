﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final___Lab2.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        
        public virtual DbSet<Nurse> Nurses { get; set; }
        public virtual DbSet<Receptionist> Receptionists { get; set; }
        public virtual DbSet<Technical> Technicals { get; set; }
        public virtual DbSet<Pacient> Pacients { get; set; }
        public virtual DbSet<Terapi>Terapis { get; set; }
        public virtual DbSet<Faktura> Fakturas { get; set; }
        
        public virtual DbSet<OrariPune> OrariPunes { get; set; }
        public virtual DbSet<KontrollaMjeksore> KontrollaMjeksores { get; set; }
        public virtual DbSet<Pagesa> Pagesas { get; set; }
        public virtual DbSet<Analizat> Analizats { get; set; }
        public virtual DbSet<FeedBack> FeedBacks { get; set; }
        public virtual DbSet<Detajet> Detajets { get; set; }
        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<KategoriaAnalizave> KategoriaAnalizaves { get; set; }

    }
}
