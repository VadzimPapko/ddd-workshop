﻿using DddWorkshop.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DddWorkshop.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Product> Products { get; set; }
        
        public DbSet<AuditLog> AuditLogs { get; set; }
        
        public DbSet<Order> Orders { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}