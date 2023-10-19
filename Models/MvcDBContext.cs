using Microsoft.EntityFrameworkCore;

namespace SP3064751MVCDB.Models;

public class MvcDBContext : DbContext
{
    public DbSet<Editora> Editora { get; set; }
    
    public DbSet<Livro> Livro { get; set; }
    
    public MvcDBContext(DbContextOptions<MvcDBContext> options) : base(options)
    {
        
    }
}