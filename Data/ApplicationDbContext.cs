﻿using System;
using System.Collections.Generic;
using System.Text;
using DotNext.DddWorkshop.Areas.Products.Domain;
using DotNext.DddWorkshop.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DotNext.DddWorkshop.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Product> Products { get; set; }
        
        public DbSet<AuditLog> AuditLogs { get; set; }
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}