using Microsoft.EntityFrameworkCore;

namespace EventAsp.Models
{
    public class EventDbContext : DbContext
    {
        public EventDbContext(DbContextOptions<EventDbContext> options) : base(options)
        {}

        public DbSet<Event> Events { get; set; }
    }
}
