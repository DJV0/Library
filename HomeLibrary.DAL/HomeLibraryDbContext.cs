﻿using HomeLibrary.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeLibrary.DAL
{
    public class HomeLibraryDbContext : DbContext
    {
        public DbSet<Image> Images { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public HomeLibraryDbContext(DbContextOptions options) : base(options) { }
    }
}
