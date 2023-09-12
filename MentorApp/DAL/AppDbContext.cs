﻿using MentorApp.Models;
using Microsoft.EntityFrameworkCore;

namespace MentorApp.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {


        }
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<Service> Services { get; set; }

        public DbSet<PricingServices> PricingServices { get; set; }




    }
}
