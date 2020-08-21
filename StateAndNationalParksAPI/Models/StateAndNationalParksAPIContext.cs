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
        new NationalPark { NationalParkId = 1, Name = "Denali", State = "Alaska", Region = "Alaska" },
        new NationalPark { NationalParkId = 2, Name = "Gates of the Arctic", State = "Alaska", Region = "Alaska" },
        new NationalPark { NationalParkId = 3, Name = "Glacier Bay", State = "Alaska", Region = "Alaska" },
        new NationalPark { NationalParkId = 4, Name = "Katmai", State = "Alaska", Region = "Alaska" },
        new NationalPark { NationalParkId = 5, Name = "Kenai Fjords", State = "Alaska", Region = "Alaska" },
        new NationalPark { NationalParkId = 6, Name = "Kobuk Valley", State = "Alaska", Region = "Alaska" },
        new NationalPark { NationalParkId = 7, Name = "Lake Clark", State = "Alaska", Region = "Alaska" },
        new NationalPark { NationalParkId = 8, Name = "Wrangell - St.Elias", State = "Alaska", Region = "Alaska" },
        new NationalPark { NationalParkId = 9, Name = "American Samoa", State = "American Samoa", Region = "Pacific" },
        new NationalPark { NationalParkId = 10, Name = "Grand Canyon", State = "Arizona", Region = "Southwest" },
        new NationalPark { NationalParkId = 11, Name = "Petrified Forest", State = "Arizona", Region = "Southwest" },
        new NationalPark { NationalParkId = 12, Name = "Saguaro", State = "Arizona", Region = "Southwest" },
        new NationalPark { NationalParkId = 13, Name = "Organ Pipe Cactus", State = "Arizona", Region = "Southwest" },
        new NationalPark { NationalParkId = 14, Name = "Hot Springs", State = "Arkansas", Region = "South" },
        new NationalPark { NationalParkId = 15, Name = "Channel Islands", State = "California", Region = "Pacific Southwest" },
        new NationalPark { NationalParkId = 16, Name = "Death Valley", State = "California", Region = "Southwest" },
        new NationalPark { NationalParkId = 17, Name = "Joshua Tree", State = "California", Region = "Pacific Southwest" },
        new NationalPark { NationalParkId = 18, Name = "Kings Canyon", State = "California", Region = "Pacific Southwest" },
        new NationalPark { NationalParkId = 19, Name = "Redwood", State = "California", Region = "Pacific Northwest" },
        new NationalPark { NationalParkId = 20, Name = "Yosemite", State = "California", Region = "Pacific Southwest" },
        new NationalPark { NationalParkId = 21, Name = "Sequoia", State = "California", Region = "Pacific Northwest" },
        new NationalPark { NationalParkId = 22, Name = "Black Canyon of the Gunnison", State = "Colorado", Region = "Southwest" },
        new NationalPark { NationalParkId = 23, Name = "Great Sand Dunes", State = "Colorado", Region = "Southwest" },
        new NationalPark { NationalParkId = 24, Name = "Mesa Verde", State = "Colorado", Region = "Southwest" },
        new NationalPark { NationalParkId = 25, Name = "Rocky Mountain", State = "Colorado", Region = "Southwest" },
        new NationalPark { NationalParkId = 26, Name = "Biscayne", State = "Florida", Region = "Southeast" },
        new NationalPark { NationalParkId = 27, Name = "Dry Tortugas", State = "Florida", Region = "Atlantic Southeast" },
        new NationalPark { NationalParkId = 28, Name = "Everglades", State = "Florida", Region = "Atlantic Southeast" },
        new NationalPark { NationalParkId = 29, Name = "Haleakala", State = "Hawaii", Region = "Pacific" },
        new NationalPark { NationalParkId = 30, Name = "Hawaii Volacanoes", State = "Hawaii", Region = "Pacific" },
        new NationalPark { NationalParkId = 31, Name = "Yellowstone", State = "Wyoming", Region = "Northwest" },
        new NationalPark { NationalParkId = 32, Name = "Mammoth Cave", State = "Kentucky", Region = "Southeast" },
        new NationalPark { NationalParkId = 33, Name = "Isle Royale", State = "Michigan", Region = "Midwest" },
        new NationalPark { NationalParkId = 34, Name = "Voyageurs", State = "Minnesota", Region = "Midwest" },
        new NationalPark { NationalParkId = 35, Name = "Glacier", State = "Montana", Region = "Northwest" },
        new NationalPark { NationalParkId = 36, Name = "Great Basin", State = "Nevada", Region = "Southwest" },
        new NationalPark { NationalParkId = 37, Name = "Carlsbad Caverns", State = "New Mexico", Region = "Southwest" },
        new NationalPark { NationalParkId = 38, Name = "Great Smoky Mountains", State = "North Carolina", Region = "Southeast" },
        new NationalPark { NationalParkId = 39, Name = "Theodore Roosevelt", State = "North Dakota", Region = "Midwest" },
        new NationalPark { NationalParkId = 40, Name = "Cuyahoga Valley", State = "Ohio", Region = "Midwest" },
        new NationalPark { NationalParkId = 41, Name = "Crater Lake", State = "Oregon", Region = "Pacific Northwest" },
        new NationalPark { NationalParkId = 42, Name = "Congaree", State = "South Carolina", Region = "Southeast" },
        new NationalPark { NationalParkId = 43, Name = "Badlands", State = "South Dakota", Region = "Midwest" },
        new NationalPark { NationalParkId = 44, Name = "Wind Cave", State = "South Dakota", Region = "Midwest" },
        new NationalPark { NationalParkId = 45, Name = "Great Smoky Mountains", State = "Tennessee", Region = "Southeast" },
        new NationalPark { NationalParkId = 46, Name = "Big Bend", State = "Texas", Region = "Southwest" },
        new NationalPark { NationalParkId = 47, Name = "Guadalupe Mountains", State = "Texas", Region = "Southwest" },
        new NationalPark { NationalParkId = 48, Name = "Virgin Islands", State = "United States Virgin Islands", Region = "Carribean" },
        new NationalPark { NationalParkId = 49, Name = "Arches", State = "Utah", Region = "Southwest" },
        new NationalPark { NationalParkId = 50, Name = "Bryce Canyon", State = "Utah", Region = "Southwest" },
        new NationalPark { NationalParkId = 51, Name = "Canyonlands", State = "Utah", Region = "Southwest" },
        new NationalPark { NationalParkId = 52, Name = "Capitol Reef", State = "Utah", Region = "Southwest" },
        new NationalPark { NationalParkId = 53, Name = "Zion", State = "Utah", Region = "Southwest" },
        new NationalPark { NationalParkId = 54, Name = "Shenandoah", State = "Virginia", Region = "Southeast" },
        new NationalPark { NationalParkId = 55, Name = "Mount Rainier", State = "Washington", Region = "Pacific Northwest" },
        new NationalPark { NationalParkId = 56, Name = "North Cascades", State = "Washington", Region = "Pacific Northwest" },
        new NationalPark { NationalParkId = 57, Name = "Olympic", State = "Washington", Region = "Pacific Northwest" },
        new NationalPark { NationalParkId = 58, Name = "Grand Teton", State = "Washington", Region = "Northwest" }
      );
    builder.Entity<StatePark>()
      .HasData(
        new StatePark { StateParkId = 1, Name = "Goose Lake State Recreation Area", State = "Oregon", County = "Lakeview"},
        new StatePark { StateParkId = 2, Name = "Frechglen Hotel State Heritage Site", State = "Oregon", County = "Burns"},
        new StatePark { StateParkId = 3, Name = "Ontario State Recreation Site", State = "Oregon", County = "Ontario"},
        new StatePark { StateParkId = 4, Name = "Farewell Bend State Recreation Area", State = "Oregon", County = "Ontario"},
        new StatePark { StateParkId = 5, Name = "Kam Wah Chung State Heritage Site", State = "Oregon", County = "John Day"},
        new StatePark { StateParkId = 6, Name = "Unity Lake State Recreation Site", State = "Oregon", County = "John Day"},
        new StatePark { StateParkId = 7, Name = "Succor Creek State Natural Area", State = "Oregon", County = "Nyssa"},
        new StatePark { StateParkId = 8, Name = "Lake Owyhee State Park", State = "Oregon", County = "Nyssa"},
        new StatePark { StateParkId = 9, Name = "Catherine Creek State Park", State = "Oregon", County = "Union"},
        new StatePark { StateParkId = 10, Name = "Alta Lake State Park", State = "Washington", County = "Okanogan"},
        new StatePark { StateParkId = 11, Name = "Anderson Lake State Park", State = "Washington", County = "Jefferson"},
        new StatePark { StateParkId = 12, Name = "Battle Ground Lake State Park", State = "Washington", County = "Clark"},
        new StatePark { StateParkId = 13, Name = "Bay View State Park", State = "Washington", County = "Skagit"},
        new StatePark { StateParkId = 14, Name = "Beacon Rock State Park", State = "Washington", County = "Skamania"},
        new StatePark { StateParkId = 15, Name = "Belfair State Park", State = "Washington", County = "Mason"},
        new StatePark { StateParkId = 16, Name = "Birch Bay", State = "Washington", County = "Whatcom"},
        new StatePark { StateParkId = 17, Name = "Blind Island State Park", State = "Washington", County = "San Juan"},
        new StatePark { StateParkId = 18, Name = "Albany State Marine Reserve", State = "California", County = "Alameda"},
        new StatePark { StateParkId = 19, Name = "Ahjumawi Lava Springs State Park", State = "California", County = "Shasta"},
        new StatePark { StateParkId = 20, Name = "Anderson Marsh State Historic Park", State = "California", County = "Lake"},
        new StatePark { StateParkId = 21, Name = "Andrew Molera State Park", State = "California", County = "Monterey"},
        new StatePark { StateParkId = 22, Name = "Angel Island State Park", State = "California", County = "Marin"},
        new StatePark { StateParkId = 23, Name = "Antelope Valley California Poppy Reserve", State = "California", County = "Los Angeles"},
        new StatePark { StateParkId = 24, Name = "Burton Creek State Park", State = "California", County = "Placer"},
        new StatePark { StateParkId = 25, Name = "Butano State Park", State = "California", County = "San Mateo"},
        new StatePark { StateParkId = 26, Name = "Butte City Project", State = "California", County = "Butte"},
        new StatePark { StateParkId = 27, Name = "Calaveras Big Trees State Park", State = "California", County = "Calaveras"},
        new StatePark { StateParkId = 28, Name = "California Citrus State Historic Park", State = "California", County = "Riverside"},
        new StatePark { StateParkId = 29, Name = "California State Marine Park", State = "California", County = "San Luis Obispo"},
        new StatePark { StateParkId = 30, Name = "Cardiff State Beach", State = "California", County = "San Diego"},
        new StatePark { StateParkId = 31, Name = "Castle Crags State Park", State = "California", County = "Shasta"},
        new StatePark { StateParkId = 32, Name = "Caswell Memorial State Park", State = "California", County = "San Joaquin"},
        new StatePark { StateParkId = 33, Name = "China Camp State Park", State = "California", County = "Marin"},
        new StatePark { StateParkId = 34, Name = "Lake Elemo State Park", State = "Montana", County = "Yellowstone"},
        new StatePark { StateParkId = 35, Name = "Lake Mary Ronan State Park", State = "Montana", County = "Lake"},
        new StatePark { StateParkId = 36, Name = "Lewis and Clark Caverns State Park", State = "Montana", County = "Jefferson"},
        new StatePark { StateParkId = 37, Name = "Lone Pine State Park", State = "Montana", County = "Flathead"},
        new StatePark { StateParkId = 38, Name = "Lost Creek State Park", State = "Montana", County = "Deer Lodge"},
        new StatePark { StateParkId = 39, Name = "Milltown State Park", State = "Montana", County = "Missoula"},
        new StatePark { StateParkId = 40, Name = "Missouri Headwaters State Park", State = "Montana", County = "Gallatin"},
        new StatePark { StateParkId = 41, Name = "Salmon Lake State Park", State = "Montana", County = "Missoula"},
        new StatePark { StateParkId = 42, Name = "Spring Meadow Lake State Park", State = "Montana", County = "Lewis and Clark"}
      );
    }
  }
}