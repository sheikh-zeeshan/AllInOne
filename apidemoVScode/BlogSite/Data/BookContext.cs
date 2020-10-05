using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogSite.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogSite.Data
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> opt): base(opt)
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<BookGallery> BooksGallery { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("");
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
