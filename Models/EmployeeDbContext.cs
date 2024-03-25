using Microsoft.EntityFrameworkCore;

namespace EmployeeApi.Models
{
    public class EmployeeDbContext : DbContext
{
    public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
    {
    }
    public DbSet<Employee> Employees { get; set; }
  
        protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>().HasData(
            new Employee { empid = 1, Name = "Action", department = "HR", designation="software engineer" },
             new Employee { empid = 2, Name = "SciFi", department = "IT", designation = " engineer" },
              new Employee { empid = 3, Name = "History", department = "Devops", designation = "lead software engineer" }
            );
      
    }
}
}
