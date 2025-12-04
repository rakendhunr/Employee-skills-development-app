using EmployeeSkillDevelopmentApi.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeSkillDevelopmentApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<EmployeeSkill> EmployeeSkills { get; set; }

        
    }
}
