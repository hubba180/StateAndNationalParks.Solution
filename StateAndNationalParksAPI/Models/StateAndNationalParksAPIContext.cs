using Microsoft.EntityFrameworkCore;

namespace StateAndNationalParksAPI.Models
{
  public class StateAndNationalParksAPIContext : DbContext
  {
    public StateAndNationalParksAPIContext(DbContextOptions<StateAndNationalParksAPIContext> options) : base(options)
    {
      
    }
    public DbSet<NationalPark> NationalParks { get; set; }
    public DbSet<StatePark> StateParks { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
    builder.Entity<NationalPark>()
      .HasData();
    builder.Entity<StatePark>()
      .HasData();
    }
  }
}