using cluster.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace cluster.Api
{
    public class DataContext : DbContext
    {
        public DbSet <City> Cities { get; set; }
    }
}
