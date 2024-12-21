using Microsoft.EntityFrameworkCore;
using WebApp_v1.Models;

namespace WebApp_v1.Data
{
    public class MyAppContext : DbContext
    {
        public MyAppContext(DbContextOptions<MyAppContext> options) : base(options)
        {
        }
        public DbSet<Item> Items { get; set; }

    }
}