using Microsoft.EntityFrameworkCore;
using PaymentDetail.Controllers;

namespace PaymentDetail.Model
{
    public class Context: DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<CardInfo> card { get; set; }
        public DbSet<Utenti> utenti { get; set; }

    }
}
