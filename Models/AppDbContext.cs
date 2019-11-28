using Microsoft.EntityFrameworkCore;

namespace app.Models
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("User ID=rulman;password=Rulman94312426;server=bdelse.ciqrsjsm75nr.sa-east-1.rds.amazonaws.com;Database=ElseData;");
        }
        public DbSet<Contact> Contacts  {get; set;}
    }
}