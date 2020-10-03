using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;
using Entities.Model;
namespace Entities
{
    public class RepositoryContext : DbContext
    {

        public RepositoryContext(DbContextOptions opt) : base(opt)
        {

        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Company> Companies { get; set; }

    }
}
