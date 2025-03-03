using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Forge___Workout_Tracker.Models;

namespace Forge___Workout_Tracker.Data
{
    class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<Exercise> Exercises { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }
    }
}
