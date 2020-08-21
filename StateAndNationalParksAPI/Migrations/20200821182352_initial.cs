using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StateAndNationalParksAPI.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NationalParks",
                columns: table => new
                {
                    NationalParkId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Region = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NationalParks", x => x.NationalParkId);
                });

            migrationBuilder.CreateTable(
                name: "StateParks",
                columns: table => new
                {
                    StateParkId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    County = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StateParks", x => x.StateParkId);
                });

            migrationBuilder.InsertData(
                table: "NationalParks",
                columns: new[] { "NationalParkId", "Name", "Region", "State" },
                values: new object[,]
                {
                    { 1, "Denali", "Alaska", "Alaska" },
                    { 32, "Mammoth Cave", "Southeast", "Kentucky" },
                    { 33, "Isle Royale", "Midwest", "Michigan" },
                    { 34, "Voyageurs", "Midwest", "Minnesota" },
                    { 35, "Glacier", "Northwest", "Montana" },
                    { 36, "Great Basin", "Southwest", "Nevada" },
                    { 37, "Carlsbad Caverns", "Southwest", "New Mexico" },
                    { 38, "Great Smoky Mountains", "Southeast", "North Carolina" },
                    { 39, "Theodore Roosevelt", "Midwest", "North Dakota" },
                    { 40, "Cuyahoga Valley", "Midwest", "Ohio" },
                    { 41, "Crater Lake", "Pacific Northwest", "Oregon" },
                    { 42, "Congaree", "Southeast", "South Carolina" },
                    { 43, "Badlands", "Midwest", "South Dakota" },
                    { 31, "Yellowstone", "Northwest", "Wyoming" },
                    { 44, "Wind Cave", "Midwest", "South Dakota" },
                    { 46, "Big Bend", "Southwest", "Texas" },
                    { 47, "Guadalupe Mountains", "Southwest", "Texas" },
                    { 48, "Virgin Islands", "Carribean", "United States Virgin Islands" },
                    { 49, "Arches", "Southwest", "Utah" },
                    { 51, "Canyonlands", "Southwest", "Utah" },
                    { 52, "Capitol Reef", "Southwest", "Utah" },
                    { 53, "Zion", "Southwest", "Utah" },
                    { 54, "Shenandoah", "Southeast", "Virginia" },
                    { 55, "Mount Rainier", "Pacific Northwest", "Washington" },
                    { 56, "North Cascades", "Pacific Northwest", "Washington" },
                    { 57, "Olympic", "Pacific Northwest", "Washington" },
                    { 58, "Grand Teton", "Northwest", "Washington" },
                    { 45, "Great Smoky Mountains", "Southeast", "Tennessee" },
                    { 30, "Hawaii Volacanoes", "Pacific", "Hawaii" },
                    { 50, "Bryce Canyon", "Southwest", "Utah" },
                    { 28, "Everglades", "Atlantic Southeast", "Florida" },
                    { 29, "Haleakala", "Pacific", "Hawaii" },
                    { 2, "Gates of the Arctic", "Alaska", "Alaska" },
                    { 3, "Glacier Bay", "Alaska", "Alaska" },
                    { 4, "Katmai", "Alaska", "Alaska" },
                    { 5, "Kenai Fjords", "Alaska", "Alaska" },
                    { 7, "Lake Clark", "Alaska", "Alaska" },
                    { 8, "Wrangell - St.Elias", "Alaska", "Alaska" },
                    { 9, "American Samoa", "Pacific", "American Samoa" },
                    { 10, "Grand Canyon", "Southwest", "Arizona" },
                    { 11, "Petrified Forest", "Southwest", "Arizona" },
                    { 12, "Saguaro", "Southwest", "Arizona" },
                    { 13, "Organ Pipe Cactus", "Southwest", "Arizona" },
                    { 14, "Hot Springs", "South", "Arkansas" },
                    { 6, "Kobuk Valley", "Alaska", "Alaska" },
                    { 16, "Death Valley", "Southwest", "California" },
                    { 27, "Dry Tortugas", "Atlantic Southeast", "Florida" },
                    { 15, "Channel Islands", "Pacific Southwest", "California" },
                    { 26, "Biscayne", "Southeast", "Florida" },
                    { 25, "Rocky Mountain", "Southwest", "Colorado" },
                    { 23, "Great Sand Dunes", "Southwest", "Colorado" },
                    { 22, "Black Canyon of the Gunnison", "Southwest", "Colorado" },
                    { 24, "Mesa Verde", "Southwest", "Colorado" },
                    { 20, "Yosemite", "Pacific Southwest", "California" },
                    { 19, "Redwood", "Pacific Northwest", "California" },
                    { 18, "Kings Canyon", "Pacific Southwest", "California" },
                    { 17, "Joshua Tree", "Pacific Southwest", "California" },
                    { 21, "Sequoia", "Pacific Northwest", "California" }
                });

            migrationBuilder.InsertData(
                table: "StateParks",
                columns: new[] { "StateParkId", "County", "Name", "State" },
                values: new object[,]
                {
                    { 24, "Placer", "Burton Creek State Park", "California" },
                    { 30, "San Diego", "Cardiff State Beach", "California" },
                    { 23, "Los Angeles", "Antelope Valley California Poppy Reserve", "California" },
                    { 25, "San Mateo", "Butano State Park", "California" },
                    { 26, "Butte", "Butte City Project", "California" },
                    { 27, "Calaveras", "Calaveras Big Trees State Park", "California" },
                    { 28, "Riverside", "California Citrus State Historic Park", "California" },
                    { 29, "San Luis Obispo", "California State Marine Park", "California" },
                    { 31, "Shasta", "Castle Crags State Park", "California" },
                    { 36, "Jefferson", "Lewis and Clark Caverns State Park", "Montana" },
                    { 33, "Marin", "China Camp State Park", "California" },
                    { 34, "Yellowstone", "Lake Elemo State Park", "Montana" },
                    { 35, "Lake", "Lake Mary Ronan State Park", "Montana" },
                    { 37, "Flathead", "Lone Pine State Park", "Montana" },
                    { 38, "Deer Lodge", "Lost Creek State Park", "Montana" },
                    { 39, "Missoula", "Milltown State Park", "Montana" },
                    { 22, "Marin", "Angel Island State Park", "California" },
                    { 40, "Gallatin", "Missouri Headwaters State Park", "Montana" },
                    { 32, "San Joaquin", "Caswell Memorial State Park", "California" },
                    { 21, "Monterey", "Andrew Molera State Park", "California" },
                    { 7, "Nyssa", "Succor Creek State Natural Area", "Oregon" },
                    { 19, "Shasta", "Ahjumawi Lava Springs State Park", "California" },
                    { 41, "Missoula", "Salmon Lake State Park", "Montana" },
                    { 1, "Lakeview", "Goose Lake State Recreation Area", "Oregon" },
                    { 2, "Burns", "Frechglen Hotel State Heritage Site", "Oregon" },
                    { 3, "Ontario", "Ontario State Recreation Site", "Oregon" },
                    { 4, "Ontario", "Farewell Bend State Recreation Area", "Oregon" },
                    { 5, "John Day", "Kam Wah Chung State Heritage Site", "Oregon" },
                    { 6, "John Day", "Unity Lake State Recreation Site", "Oregon" },
                    { 8, "Nyssa", "Lake Owyhee State Park", "Oregon" },
                    { 20, "Lake", "Anderson Marsh State Historic Park", "California" },
                    { 9, "Union", "Catherine Creek State Park", "Oregon" },
                    { 11, "Jefferson", "Anderson Lake State Park", "Washington" },
                    { 12, "Clark", "Battle Ground Lake State Park", "Washington" },
                    { 13, "Skagit", "Bay View State Park", "Washington" },
                    { 14, "Skamania", "Beacon Rock State Park", "Washington" },
                    { 15, "Mason", "Belfair State Park", "Washington" },
                    { 16, "Whatcom", "Birch Bay", "Washington" },
                    { 17, "San Juan", "Blind Island State Park", "Washington" },
                    { 18, "Alameda", "Albany State Marine Reserve", "California" },
                    { 10, "Okanogan", "Alta Lake State Park", "Washington" },
                    { 42, "Lewis and Clark", "Spring Meadow Lake State Park", "Montana" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NationalParks");

            migrationBuilder.DropTable(
                name: "StateParks");
        }
    }
}
