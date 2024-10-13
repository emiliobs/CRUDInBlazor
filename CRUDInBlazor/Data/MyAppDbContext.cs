using CRUDInBlazor.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDInBlazor.Data
{
    public class MyAppDbContext : DbContext
    {
        public MyAppDbContext(DbContextOptions<MyAppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Product { get; set; } = default!;
    }
}