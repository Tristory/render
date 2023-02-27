using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace Test6.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        public DbSet<Test6.Models.Category> Categories { get; set; }
        public DbSet<Test6.Models.Comment> Comments { get; set; }
        public DbSet<Test6.Models.Department> Departments { get; set; }
        public DbSet<Test6.Models.Idea> Ideas { get; set; }
        public DbSet<Test6.Models.React> Reacts { get; set; }
        public DbSet<Test6.Models.Role> Roles { get; set; }
        public DbSet<Test6.Models.Topic> Topics { get; set; }
        public DbSet<Test6.Models.User> Users { get; set; }
        public DbSet<Test6.Models.View> Views { get; set; }
    }
}