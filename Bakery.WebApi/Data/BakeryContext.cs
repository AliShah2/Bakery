using Bakery.WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace Bakery.WebApi.Data
{
    public class BakeryContext : DbContext
    {
        public BakeryContext(DbContextOptions<BakeryContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
