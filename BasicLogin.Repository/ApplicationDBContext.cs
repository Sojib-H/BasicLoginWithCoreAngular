using BasicLogin.Model;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Globalization;

namespace BasicLogin.Repository
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options) { }

        public DbSet<CompanyInfo> CompanyInfo { get; set; }
        public DbSet<EmployeeInfo> EmployeeInfo { get; set; }
        public DbSet<UserInfo> UserInfo { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<RolePermission> RolePermission { get; set; }
        public DbSet<Role> Role { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
