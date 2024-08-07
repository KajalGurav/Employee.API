﻿using Employee.API.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Employee.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
       
      
    }
}
