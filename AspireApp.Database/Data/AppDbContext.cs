using AspireApp.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspireApp.Database.Data
{
    public class AppDbContext : DbContext
    {
        //Contructor
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            //make db & schema if doesn't already exist
            Database.EnsureCreated();
        }

        public DbSet<ProductModel> Products { get; set; }
    }
}
