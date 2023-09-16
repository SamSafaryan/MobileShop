﻿using Microsoft.EntityFrameworkCore;
using WebApplication2.Data.Entities;
namespace WebApplication2.Data
{
    public class MobileShopDataContext : DbContext
    {
        public MobileShopDataContext(DbContextOptions<MobileShopDataContext> opt) : base(opt)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
    }
}
