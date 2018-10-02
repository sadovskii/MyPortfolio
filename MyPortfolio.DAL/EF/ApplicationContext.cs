using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MyPortfolio.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyPortfolio.DAL.EF
{
    public class ApplicationContext : IdentityDbContext<User>
    {
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Record> Records { get; set; }
        public DbSet<TypeRecord> TypeRecords { get; set; }


        public ApplicationContext(DbContextOptions<ApplicationContext> options)
             : base(options)
        {
            Database.EnsureCreated();
        }

        public ApplicationContext()
            : base()
        { }

    }
}
