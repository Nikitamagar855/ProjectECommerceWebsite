using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectECommerceWebsite.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectECommerceWebsite.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Inventry> Inventry { get; set; }

        public DbSet<Category> Category { get; set; }
    }
}
