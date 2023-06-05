using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

public class Context : DbContext{
    public Context(DbContextOptions<Context>options) : base(options){}
    public DbSet<Ingresos> ingreso{get; set;}
}