using BankoOfDotNetAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BankoOfDotNetAPI.Data
{
    public class BankContext : DbContext
    {
        public BankContext(DbContextOptions<BankContext> options) : base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
    }
}
