using Microsoft.EntityFrameworkCore;
using TabelaLigi.Db.Models;

namespace TabelaLigi.Db;

public class LigaContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlite("Data Source=liga.db");
    }

    public DbSet<Team> Teams { get; set; }
}