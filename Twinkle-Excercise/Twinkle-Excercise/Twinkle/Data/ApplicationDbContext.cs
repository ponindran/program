using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Twinkle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Store.Twinkle.BaseContext;
using Twinkle.Mvc.Data;

namespace Twinkle.Data
{
    public class ApplicationDbContext : Context, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //public DbSet<Category> Category { get; set; }
        //public DbSet<ApplicationType> ApplicationType { get; set; }
        //public DbSet<Product> Product { get; set; }
        //public DbSet<ApplicationUser> ApplicationUser { get; set; }

        public DbSet<ProductInfo> ProductInfo { get; set; }
        public DbSet<PriceInfo> PriceInfo { get; set; }
    }
}
