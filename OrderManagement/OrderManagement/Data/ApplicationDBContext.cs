using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OrderManagement.Models;

namespace OrderManagement.Data
{
    public class ApplicationDBContext : DbContext
    {
        public  ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Category { set; get; }
        
        public DbSet<ApplicationType> ApplicationType { get; set; }
    }
}
