﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DerExam.Net.Data
{
    public class MyContext:DbContext
    {
        public MyContext(DbContextOptions<MyContext> options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new AlbumConfiguration());
        }

        //public DbSet<Album> Albums { get; set; }
    }
}
