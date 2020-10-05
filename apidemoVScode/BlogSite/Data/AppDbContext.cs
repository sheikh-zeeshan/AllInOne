using BlogSite.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.Data
{
    public class AppDbContext : IdentityDbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> opts) : base(opts)
        {

        }
 
        public DbSet<Post> Posts { get; set; }

        public DbSet<MainComments> MainComments { get; set; }
        public DbSet<SubComments> SubComments { get; set; }

       // public DbSet<Book> Books{ get; set; }
    }

    //public class ctx: DbContext
    //{
    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    {
    //        optionsBuilder.UseSqlServer("");
    //        base.OnConfiguring(optionsBuilder);
    //    }
    //}
}
