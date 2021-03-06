﻿using CatApi.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace CatApi.DAL.EF
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
       public DbSet<Image> Images { get; set; }
    }
}
