using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //  {
        //       base.OnConfiguring(optionsBuilder);
        //      optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=payment;Trusted_Connection=True;");
        // }
        public DbSet<PaymentDetail> PaymentDetails { get; set; }
    }
}
