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

        public DbSet<Movie> Movie { get; set; }

        public DbSet<NetCoreDemo.Models.Employee> Employee { get; set; }

        public DbSet<NetCoreDemo.Models.Product> Product { get; set; }

        public DbSet<Student> Student { get; set; }
        
        public DbSet<Person> Person { get; set; }
        
        public DbSet<HoaDon> HoaDon { get; set; }
        
        public DbSet<KhachHang> KhachHang { get; set; }
        
        public DbSet<NetCoreDemo.Models.NhanVien> NhanVien { get; set; }
        
        public DbSet<NetCoreDemo.Models.LuongBong> LuongBong { get; set; }
        
        public DbSet<NetCoreDemo.Models.Teacher> Teacher { get; set; }

    }

}