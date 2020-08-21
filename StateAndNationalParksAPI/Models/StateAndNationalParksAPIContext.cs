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
        new NationalPark { Name = "Grand Teton", State = "Washington", Region = "Northwest" }
      );
    builder.Entity<StatePark>()
      .HasData(
        new StatePark { Name = "Goose Lake State Recreation Area", State = "Oregon", County = "Lakeview"},
        new StatePark { Name = "Frechglen Hotel State Heritage Site", State = "Oregon", County = "Burns"},
        new StatePark { Name = "Ontario State Recreation Site", State = "Oregon", County = "Ontario"},
        new StatePark { Name = "Farewell Bend State Recreation Area", State = "Oregon", County = "Ontario"},
        new StatePark { Name = "Kam Wah Chung State Heritage Site", State = "Oregon", County = "John Day"},
        new StatePark { Name = "Unity Lake State Recreation Site", State = "Oregon", County = "John Day"},
        new StatePark { Name = "Succor Creek State Natural Area", State = "Oregon", County = "Nyssa"},
        new StatePark { Name = "Lake Owyhee State Park", State = "Oregon", County = "Nyssa"},
        new StatePark { Name = "Catherine Creek State Park", State = "Oregon", County = "Union"},
        new StatePark { Name = "Alta Lake State Park", State = "Washington", County = "Okanogan"},
        new StatePark { Name = "Anderson Lake State Park", State = "Washington", County = "Jefferson"},
        new StatePark { Name = "Battle Ground Lake State Park", State = "Washington", County = "Clark"},
        new StatePark { Name = "Bay View State Park", State = "Washington", County = "Skagit"},
        new StatePark { Name = "Beacon Rock State Park", State = "Washington", County = "Skamania"},
        new StatePark { Name = "Belfair State Park", State = "Washington", County = "Mason"},
        new StatePark { Name = "Birch Bay", State = "Washington", County = "Whatcom"},
        new StatePark { Name = "Blind Island State Park", State = "Washington", County = "San Juan"},
        new StatePark { Name = "Albany State Marine Reserve", State = "California", County = "Alameda"},
        new StatePark { Name = "Ahjumawi Lava Springs State Park", State = "California", County = "Shasta"},
        new StatePark { Name = "Anderson Marsh State Historic Park", State = "California", County = "Lake"},
        new StatePark { Name = "Andrew Molera State Park", State = "California", County = "Monterey"},
        new StatePark { Name = "Angel Island State Park", State = "California", County = "Marin"},
        new StatePark { Name = "Antelope Valley California Poppy Reserve", State = "California", County = "Los Angeles"},
        new StatePark { Name = "Burton Creek State Park", State = "California", County = "Placer"},
        new StatePark { Name = "Butano State Park", State = "California", County = "San Mateo"},
        new StatePark { Name = "Butte City Project", State = "California", County = "Butte"},
        new StatePark { Name = "Calaveras Big Trees State Park", State = "California", County = "Calaveras"},
        new StatePark { Name = "California Citrus State Historic Park", State = "California", County = "Riverside"},
        new StatePark { Name = "California State Marine Park", State = "California", County = "San Luis Obispo"},
        new StatePark { Name = "Cardiff State Beach", State = "California", County = "San Diego"},
        new StatePark { Name = "Castle Crags State Park", State = "California", County = "Shasta"},
        new StatePark { Name = "Caswell Memorial State Park", State = "California", County = "San Joaquin"},
        new StatePark { Name = "China Camp State Park", State = "California", County = "Marin"},
        new StatePark { Name = "Lake Elemo State Park", State = "Montana", County = "Yellowstone"},
        new StatePark { Name = "Lake Mary Ronan State Park", State = "Montana", County = "Lake"},
        new StatePark { Name = "Lewis and Clark Caverns State Park", State = "Montana", County = "Jefferson"},
        new StatePark { Name = "Lone Pine State Park", State = "Montana", County = "Flathead"},
        new StatePark { Name = "Lost Creek State Park", State = "Montana", County = "Deer Lodge"},
        new StatePark { Name = "Milltown State Park", State = "Montana", County = "Missoula"},
        new StatePark { Name = "Missouri Headwaters State Park", State = "Montana", County = "Gallatin"},
        new StatePark { Name = "Salmon Lake State Park", State = "Montana", County = "Missoula"},
        new StatePark { Name = "Spring Meadow Lake State Park", State = "Montana", County = "Lewis and Clark"}
      );
    }
  }
}