
using HRMS.Models;
using Microsoft.EntityFrameworkCore;

namespace HRMS.Database
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=localhost;Database=HRMS;User Id=sa;Password=123@#@#hH;TrustServerCertificate=True;MultipleActiveResultSets=true"
            );
        }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Leave> Leaves { get; set; }
        public DbSet<Payroll> Payrolls { get; set; }
        public DbSet<Training> Trainings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}