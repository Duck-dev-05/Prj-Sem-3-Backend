using Microsoft.EntityFrameworkCore;
using JamesThew.Model;

namespace JamesThew.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public required DbSet<User> Users { get; set; }
        public required DbSet<Recipe> Recipes { get; set; }
        public required DbSet<Contest> Contests { get; set; }
        public required DbSet<Feedback> Feedbacks { get; set; }
    }
}
