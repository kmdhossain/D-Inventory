using DInventory.DataServices.EFCore.AppDbContext;
using Microsoft.EntityFrameworkCore;

namespace DInventory.DataServices.EFCore;

public class InMemoryDbContext : AppDatabaseContext
{
    public InMemoryDbContext() : base(new DbContextOptionsBuilder<AppDatabaseContext>().Options)
    {
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase("x");
    }
}