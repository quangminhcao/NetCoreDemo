using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NetCoreDemo.Models;
namespace NetCoreDemo.Data{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<NetCoreDemo.Models.Movie> Movie { get; set; }

        public DbSet<NetCoreDemo.Models.Employee> Employee { get; set; }

        public DbSet<NetCoreDemo.Models.Person> Person { get; set; }

        public DbSet<NetCoreDemo.Models.Product> Product { get; set; }

        public DbSet<NetCoreDemo.Models.Student> Student { get; set; }
    }

}