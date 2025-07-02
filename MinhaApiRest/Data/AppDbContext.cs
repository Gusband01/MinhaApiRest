using Microsoft.EntityFrameworkCore;
using MinhaApiRest.Models;

namespace MinhaApiRest.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<Mensagem> Mensagens { get; set; }
}