using Microsoft.EntityFrameworkCore;
using SalesCet1052.Web.Data.Entities;

namespace SalesCet1052.Web.Data
{
    public class DataContext : DbContext
    {
        // Code Firts and Database first
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
        }
    
        // public DbSet<SalesCet1052.Web.Data.Entities.Country> Countries { get; set; }
        public DbSet<Country> Countries { get; set; }
    }
}
