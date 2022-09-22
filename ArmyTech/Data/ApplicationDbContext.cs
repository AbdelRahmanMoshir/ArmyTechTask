using ArmyTech.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ArmyTech.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions dbContextOptions):base(dbContextOptions)
        {

        }

        public DbSet<Cities> Cities { get; set; }
        public DbSet<Branches> Branches { get; set; }
        public DbSet<Cashier> Cashier { get; set; }
        public DbSet<InvoiceHeader> InvoiceHeader { get; set; }
        public DbSet<InvoiceDetails> invoiceDetails { get; set; }
    }
}
