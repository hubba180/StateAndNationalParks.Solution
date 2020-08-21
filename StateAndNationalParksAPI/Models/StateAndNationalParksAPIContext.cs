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
      .HasData(
        new NationalPark { Name = "Denali", State = "Alaska", Region = "Alaska" },
        new NationalPark { Name = "Gates of the Arctic", State = "Alaska", Region = "Alaska" },
        new NationalPark { Name = "Glacier Bay", State = "Alaska", Region = "Alaska" },
        new NationalPark { Name = "Katmai", State = "Alaska", Region = "Alaska" },
        new NationalPark { Name = "Kenai Fjords", State = "Alaska", Region = "Alaska" },
        new NationalPark { Name = "Kobuk Valley", State = "Alaska", Region = "Alaska" },
        new NationalPark { Name = "Lake Clark", State = "Alaska", Region = "Alaska" },
        new NationalPark { Name = "Wrangell - St.Elias", State = "Alaska", Region = "Alaska" },
        new NationalPark { Name = "American Samoa", State = "American Samoa", Region = "Pacific" },
        new NationalPark { Name = "Grand Canyon", State = "Arizona", Region = "Southwest" },
        new NationalPark { Name = "Petrified Forest", State = "Arizona", Region = "Southwest" },
        new NationalPark { Name = "Saguaro", State = "Arizona", Region = "Southwest" },
        new NationalPark { Name = "Organ Pipe Cactus", State = "Arizona", Region = "Southwest" },
        new NationalPark { Name = "Hot Springs", State = "Arkansas", Region = "South" },
        new NationalPark { Name = "Channel Islands", State = "California", Region = "Pacific Southwest" },
        new NationalPark { Name = "Death Valley", State = "California", Region = "Southwest" },
        new NationalPark { Name = "Joshua Tree", State = "California", Region = "Pacific Southwest" },
        new NationalPark { Name = "Kings Canyon", State = "California", Region = "Pacific Southwest" },
        new NationalPark { Name = "Redwood", State = "California", Region = "Pacific Northwest" },
        new NationalPark { Name = "Yosemite", State = "California", Region = "Pacific Southwest" },
        new NationalPark { Name = "Sequoia", State = "California", Region = "Pacific Northwest" },
        new NationalPark { Name = "Black Canyon of the Gunnison", State = "Colorado", Region = "Southwest" },
        new NationalPark { Name = "Great Sand Dunes", State = "Colorado", Region = "Southwest" },
        new NationalPark { Name = "Mesa Verde", State = "Colorado", Region = "Southwest" },
        new NationalPark { Name = "Rocky Mountain", State = "Colorado", Region = "Southwest" },
        new NationalPark { Name = "Biscayne", State = "Florida", Region = "Southeast" },
        new NationalPark { Name = "Dry Tortugas", State = "Florida", Region = "Atlantic Southeast" },
        new NationalPark { Name = "Everglades", State = "Florida", Region = "Atlantic Southeast" },
        new NationalPark { Name = "Haleakala", State = "Hawaii", Region = "Pacific" },
        new NationalPark { Name = "Hawaii Volacanoes", State = "Hawaii", Region = "Pacific" },
        new NationalPark { Name = "Yellowstone", State = "Wyoming", Region = "Northwest" },
        new NationalPark { Name = "Mammoth Cave", State = "Kentucky", Region = "Southeast" },
        new NationalPark { Name = "Isle Royale", State = "Michigan", Region = "Midwest" },
        new NationalPark { Name = "Voyageurs", State = "Minnesota", Region = "Midwest" },
        new NationalPark { Name = "Glacier", State = "Montana", Region = "Northwest" },
        new NationalPark { Name = "Great Basin", State = "Nevada", Region = "Southwest" },
        new NationalPark { Name = "Carlsbad Caverns", State = "New Mexico", Region = "Southwest" },
        new NationalPark { Name = "Great Smoky Mountains", State = "North Carolina", Region = "Southeast" },
        new NationalPark { Name = "Theodore Roosevelt", State = "North Dakota", Region = "Midwest" },
        new NationalPark { Name = "Cuyahoga Valley", State = "Ohio", Region = "Midwest" },
        new NationalPark { Name = "Crater Lake", State = "Oregon", Region = "Pacific Northwest" },
        new NationalPark { Name = "Congaree", State = "South Carolina", Region = "Southeast" },
        new NationalPark { Name = "Badlands", State = "South Dakota", Region = "Midwest" },
        new NationalPark { Name = "Wind Cave", State = "South Dakota", Region = "Midwest" },
        new NationalPark { Name = "Great Smoky Mountains", State = "Tennessee", Region = "Southeast" },
        new NationalPark { Name = "Big Bend", State = "Texas", Region = "Southwest" },
        new NationalPark { Name = "Guadalupe Mountains", State = "Texas", Region = "Southwest" },
        new NationalPark { Name = "Virgin Islands", State = "United States Virgin Islands", Region = "Carribean" },
        new NationalPark { Name = "Arches", State = "Utah", Region = "Southwest" },
        new NationalPark { Name = "Bryce Canyon", State = "Utah", Region = "Southwest" },
        new NationalPark { Name = "Canyonlands", State = "Utah", Region = "Southwest" },
        new NationalPark { Name = "Capitol Reef", State = "Utah", Region = "Southwest" },
        new NationalPark { Name = "Zion", State = "Utah", Region = "Southwest" },
        new NationalPark { Name = "Shenandoah", State = "Virginia", Region = "Southeast" },
        new NationalPark { Name = "Mount Rainier", State = "Washington", Region = "Pacific Northwest" },
        new NationalPark { Name = "North Cascades", State = "Washington", Region = "Pacific Northwest" },
        new NationalPark { Name = "Olympic", State = "Washington", Region = "Pacific Northwest" },
        new NationalPark { Name = "Grand Teton", State = "Washington", Region = "Northwest" },
      );
    builder.Entity<StatePark>()
      .HasData();
    }
  }
}