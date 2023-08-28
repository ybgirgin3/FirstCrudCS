using FirstCrud.Models;

namespace FirstCrud.Data;
using Microsoft.EntityFrameworkCore;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlite("Data Source=.\\Database\\heros.db");
    }
    
    public DbSet<SuperHero> SuperHeroes { get; set; }
}