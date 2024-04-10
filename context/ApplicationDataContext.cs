
using AMST4.Store.Shoes.Models.Entities;
using Microsoft.EntityFrameworkCore;

public class ApplicationDataContext:DbContext
{
    public ApplicationDataContext(DbContextOptions<ApplicationDataContext>options) : base (options) {}

    public DbSet<Color> Color {get;set;}

    public DbSet<Product> Product {get;set;}

    public DbSet<Size> Size {get;set;}


}