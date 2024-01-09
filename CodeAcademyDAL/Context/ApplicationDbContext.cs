using CodeAcademyDAL.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcademyDAL.Context
{
    public class ApplicationDbContext : DbContext
    {
        public readonly object Ts;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }

   
    
}
