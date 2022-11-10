using Microsoft.EntityFrameworkCore;

namespace EventAsp.Models
{
    public class EventDbContext : DbContext
    {
        public EventDbContext(DbContextOptions<EventDbContext> options) : base(options)
        {}

        public DbSet<EventModel> Events { get; set; }
        public DbSet<UserModel> Users { get; set; }
        public DbSet<ReviewModel> Reviews { get; set; }
        public DbSet<CityModel> Cities { get; set; }
    }
}
