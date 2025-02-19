﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{

    //Context : Db tabloları ile proje classlarını bağlamak.

    public class RentCarContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=RentCar;Trusted_Connection=True");
        }

        //Tablolarımı bağladım.
        public DbSet<Car> Cars { get; set; }    
        public DbSet<Color> Colors { get; set; }
        public DbSet<Brand> Brands { get; set; }



    }
}
