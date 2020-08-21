﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StateAndNationalParksAPI.Models;

namespace StateAndNationalParksAPI.Migrations
{
    [DbContext(typeof(StateAndNationalParksAPIContext))]
    partial class StateAndNationalParksAPIContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("StateAndNationalParksAPI.Models.NationalPark", b =>
                {
                    b.Property<int>("NationalParkId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Region");

                    b.Property<string>("State");

                    b.HasKey("NationalParkId");

                    b.ToTable("NationalParks");

                    b.HasData(
                        new
                        {
                            NationalParkId = 1,
                            Name = "Denali",
                            Region = "Alaska",
                            State = "Alaska"
                        },
                        new
                        {
                            NationalParkId = 2,
                            Name = "Gates of the Arctic",
                            Region = "Alaska",
                            State = "Alaska"
                        },
                        new
                        {
                            NationalParkId = 3,
                            Name = "Glacier Bay",
                            Region = "Alaska",
                            State = "Alaska"
                        },
                        new
                        {
                            NationalParkId = 4,
                            Name = "Katmai",
                            Region = "Alaska",
                            State = "Alaska"
                        },
                        new
                        {
                            NationalParkId = 5,
                            Name = "Kenai Fjords",
                            Region = "Alaska",
                            State = "Alaska"
                        },
                        new
                        {
                            NationalParkId = 6,
                            Name = "Kobuk Valley",
                            Region = "Alaska",
                            State = "Alaska"
                        },
                        new
                        {
                            NationalParkId = 7,
                            Name = "Lake Clark",
                            Region = "Alaska",
                            State = "Alaska"
                        },
                        new
                        {
                            NationalParkId = 8,
                            Name = "Wrangell - St.Elias",
                            Region = "Alaska",
                            State = "Alaska"
                        },
                        new
                        {
                            NationalParkId = 9,
                            Name = "American Samoa",
                            Region = "Pacific",
                            State = "American Samoa"
                        },
                        new
                        {
                            NationalParkId = 10,
                            Name = "Grand Canyon",
                            Region = "Southwest",
                            State = "Arizona"
                        },
                        new
                        {
                            NationalParkId = 11,
                            Name = "Petrified Forest",
                            Region = "Southwest",
                            State = "Arizona"
                        },
                        new
                        {
                            NationalParkId = 12,
                            Name = "Saguaro",
                            Region = "Southwest",
                            State = "Arizona"
                        },
                        new
                        {
                            NationalParkId = 13,
                            Name = "Organ Pipe Cactus",
                            Region = "Southwest",
                            State = "Arizona"
                        },
                        new
                        {
                            NationalParkId = 14,
                            Name = "Hot Springs",
                            Region = "South",
                            State = "Arkansas"
                        },
                        new
                        {
                            NationalParkId = 15,
                            Name = "Channel Islands",
                            Region = "Pacific Southwest",
                            State = "California"
                        },
                        new
                        {
                            NationalParkId = 16,
                            Name = "Death Valley",
                            Region = "Southwest",
                            State = "California"
                        },
                        new
                        {
                            NationalParkId = 17,
                            Name = "Joshua Tree",
                            Region = "Pacific Southwest",
                            State = "California"
                        },
                        new
                        {
                            NationalParkId = 18,
                            Name = "Kings Canyon",
                            Region = "Pacific Southwest",
                            State = "California"
                        },
                        new
                        {
                            NationalParkId = 19,
                            Name = "Redwood",
                            Region = "Pacific Northwest",
                            State = "California"
                        },
                        new
                        {
                            NationalParkId = 20,
                            Name = "Yosemite",
                            Region = "Pacific Southwest",
                            State = "California"
                        },
                        new
                        {
                            NationalParkId = 21,
                            Name = "Sequoia",
                            Region = "Pacific Northwest",
                            State = "California"
                        },
                        new
                        {
                            NationalParkId = 22,
                            Name = "Black Canyon of the Gunnison",
                            Region = "Southwest",
                            State = "Colorado"
                        },
                        new
                        {
                            NationalParkId = 23,
                            Name = "Great Sand Dunes",
                            Region = "Southwest",
                            State = "Colorado"
                        },
                        new
                        {
                            NationalParkId = 24,
                            Name = "Mesa Verde",
                            Region = "Southwest",
                            State = "Colorado"
                        },
                        new
                        {
                            NationalParkId = 25,
                            Name = "Rocky Mountain",
                            Region = "Southwest",
                            State = "Colorado"
                        },
                        new
                        {
                            NationalParkId = 26,
                            Name = "Biscayne",
                            Region = "Southeast",
                            State = "Florida"
                        },
                        new
                        {
                            NationalParkId = 27,
                            Name = "Dry Tortugas",
                            Region = "Atlantic Southeast",
                            State = "Florida"
                        },
                        new
                        {
                            NationalParkId = 28,
                            Name = "Everglades",
                            Region = "Atlantic Southeast",
                            State = "Florida"
                        },
                        new
                        {
                            NationalParkId = 29,
                            Name = "Haleakala",
                            Region = "Pacific",
                            State = "Hawaii"
                        },
                        new
                        {
                            NationalParkId = 30,
                            Name = "Hawaii Volacanoes",
                            Region = "Pacific",
                            State = "Hawaii"
                        },
                        new
                        {
                            NationalParkId = 31,
                            Name = "Yellowstone",
                            Region = "Northwest",
                            State = "Wyoming"
                        },
                        new
                        {
                            NationalParkId = 32,
                            Name = "Mammoth Cave",
                            Region = "Southeast",
                            State = "Kentucky"
                        },
                        new
                        {
                            NationalParkId = 33,
                            Name = "Isle Royale",
                            Region = "Midwest",
                            State = "Michigan"
                        },
                        new
                        {
                            NationalParkId = 34,
                            Name = "Voyageurs",
                            Region = "Midwest",
                            State = "Minnesota"
                        },
                        new
                        {
                            NationalParkId = 35,
                            Name = "Glacier",
                            Region = "Northwest",
                            State = "Montana"
                        },
                        new
                        {
                            NationalParkId = 36,
                            Name = "Great Basin",
                            Region = "Southwest",
                            State = "Nevada"
                        },
                        new
                        {
                            NationalParkId = 37,
                            Name = "Carlsbad Caverns",
                            Region = "Southwest",
                            State = "New Mexico"
                        },
                        new
                        {
                            NationalParkId = 38,
                            Name = "Great Smoky Mountains",
                            Region = "Southeast",
                            State = "North Carolina"
                        },
                        new
                        {
                            NationalParkId = 39,
                            Name = "Theodore Roosevelt",
                            Region = "Midwest",
                            State = "North Dakota"
                        },
                        new
                        {
                            NationalParkId = 40,
                            Name = "Cuyahoga Valley",
                            Region = "Midwest",
                            State = "Ohio"
                        },
                        new
                        {
                            NationalParkId = 41,
                            Name = "Crater Lake",
                            Region = "Pacific Northwest",
                            State = "Oregon"
                        },
                        new
                        {
                            NationalParkId = 42,
                            Name = "Congaree",
                            Region = "Southeast",
                            State = "South Carolina"
                        },
                        new
                        {
                            NationalParkId = 43,
                            Name = "Badlands",
                            Region = "Midwest",
                            State = "South Dakota"
                        },
                        new
                        {
                            NationalParkId = 44,
                            Name = "Wind Cave",
                            Region = "Midwest",
                            State = "South Dakota"
                        },
                        new
                        {
                            NationalParkId = 45,
                            Name = "Great Smoky Mountains",
                            Region = "Southeast",
                            State = "Tennessee"
                        },
                        new
                        {
                            NationalParkId = 46,
                            Name = "Big Bend",
                            Region = "Southwest",
                            State = "Texas"
                        },
                        new
                        {
                            NationalParkId = 47,
                            Name = "Guadalupe Mountains",
                            Region = "Southwest",
                            State = "Texas"
                        },
                        new
                        {
                            NationalParkId = 48,
                            Name = "Virgin Islands",
                            Region = "Carribean",
                            State = "United States Virgin Islands"
                        },
                        new
                        {
                            NationalParkId = 49,
                            Name = "Arches",
                            Region = "Southwest",
                            State = "Utah"
                        },
                        new
                        {
                            NationalParkId = 50,
                            Name = "Bryce Canyon",
                            Region = "Southwest",
                            State = "Utah"
                        },
                        new
                        {
                            NationalParkId = 51,
                            Name = "Canyonlands",
                            Region = "Southwest",
                            State = "Utah"
                        },
                        new
                        {
                            NationalParkId = 52,
                            Name = "Capitol Reef",
                            Region = "Southwest",
                            State = "Utah"
                        },
                        new
                        {
                            NationalParkId = 53,
                            Name = "Zion",
                            Region = "Southwest",
                            State = "Utah"
                        },
                        new
                        {
                            NationalParkId = 54,
                            Name = "Shenandoah",
                            Region = "Southeast",
                            State = "Virginia"
                        },
                        new
                        {
                            NationalParkId = 55,
                            Name = "Mount Rainier",
                            Region = "Pacific Northwest",
                            State = "Washington"
                        },
                        new
                        {
                            NationalParkId = 56,
                            Name = "North Cascades",
                            Region = "Pacific Northwest",
                            State = "Washington"
                        },
                        new
                        {
                            NationalParkId = 57,
                            Name = "Olympic",
                            Region = "Pacific Northwest",
                            State = "Washington"
                        },
                        new
                        {
                            NationalParkId = 58,
                            Name = "Grand Teton",
                            Region = "Northwest",
                            State = "Washington"
                        });
                });

            modelBuilder.Entity("StateAndNationalParksAPI.Models.StatePark", b =>
                {
                    b.Property<int>("StateParkId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("County");

                    b.Property<string>("Name");

                    b.Property<string>("State");

                    b.HasKey("StateParkId");

                    b.ToTable("StateParks");

                    b.HasData(
                        new
                        {
                            StateParkId = 1,
                            County = "Lakeview",
                            Name = "Goose Lake State Recreation Area",
                            State = "Oregon"
                        },
                        new
                        {
                            StateParkId = 2,
                            County = "Burns",
                            Name = "Frechglen Hotel State Heritage Site",
                            State = "Oregon"
                        },
                        new
                        {
                            StateParkId = 3,
                            County = "Ontario",
                            Name = "Ontario State Recreation Site",
                            State = "Oregon"
                        },
                        new
                        {
                            StateParkId = 4,
                            County = "Ontario",
                            Name = "Farewell Bend State Recreation Area",
                            State = "Oregon"
                        },
                        new
                        {
                            StateParkId = 5,
                            County = "John Day",
                            Name = "Kam Wah Chung State Heritage Site",
                            State = "Oregon"
                        },
                        new
                        {
                            StateParkId = 6,
                            County = "John Day",
                            Name = "Unity Lake State Recreation Site",
                            State = "Oregon"
                        },
                        new
                        {
                            StateParkId = 7,
                            County = "Nyssa",
                            Name = "Succor Creek State Natural Area",
                            State = "Oregon"
                        },
                        new
                        {
                            StateParkId = 8,
                            County = "Nyssa",
                            Name = "Lake Owyhee State Park",
                            State = "Oregon"
                        },
                        new
                        {
                            StateParkId = 9,
                            County = "Union",
                            Name = "Catherine Creek State Park",
                            State = "Oregon"
                        },
                        new
                        {
                            StateParkId = 10,
                            County = "Okanogan",
                            Name = "Alta Lake State Park",
                            State = "Washington"
                        },
                        new
                        {
                            StateParkId = 11,
                            County = "Jefferson",
                            Name = "Anderson Lake State Park",
                            State = "Washington"
                        },
                        new
                        {
                            StateParkId = 12,
                            County = "Clark",
                            Name = "Battle Ground Lake State Park",
                            State = "Washington"
                        },
                        new
                        {
                            StateParkId = 13,
                            County = "Skagit",
                            Name = "Bay View State Park",
                            State = "Washington"
                        },
                        new
                        {
                            StateParkId = 14,
                            County = "Skamania",
                            Name = "Beacon Rock State Park",
                            State = "Washington"
                        },
                        new
                        {
                            StateParkId = 15,
                            County = "Mason",
                            Name = "Belfair State Park",
                            State = "Washington"
                        },
                        new
                        {
                            StateParkId = 16,
                            County = "Whatcom",
                            Name = "Birch Bay",
                            State = "Washington"
                        },
                        new
                        {
                            StateParkId = 17,
                            County = "San Juan",
                            Name = "Blind Island State Park",
                            State = "Washington"
                        },
                        new
                        {
                            StateParkId = 18,
                            County = "Alameda",
                            Name = "Albany State Marine Reserve",
                            State = "California"
                        },
                        new
                        {
                            StateParkId = 19,
                            County = "Shasta",
                            Name = "Ahjumawi Lava Springs State Park",
                            State = "California"
                        },
                        new
                        {
                            StateParkId = 20,
                            County = "Lake",
                            Name = "Anderson Marsh State Historic Park",
                            State = "California"
                        },
                        new
                        {
                            StateParkId = 21,
                            County = "Monterey",
                            Name = "Andrew Molera State Park",
                            State = "California"
                        },
                        new
                        {
                            StateParkId = 22,
                            County = "Marin",
                            Name = "Angel Island State Park",
                            State = "California"
                        },
                        new
                        {
                            StateParkId = 23,
                            County = "Los Angeles",
                            Name = "Antelope Valley California Poppy Reserve",
                            State = "California"
                        },
                        new
                        {
                            StateParkId = 24,
                            County = "Placer",
                            Name = "Burton Creek State Park",
                            State = "California"
                        },
                        new
                        {
                            StateParkId = 25,
                            County = "San Mateo",
                            Name = "Butano State Park",
                            State = "California"
                        },
                        new
                        {
                            StateParkId = 26,
                            County = "Butte",
                            Name = "Butte City Project",
                            State = "California"
                        },
                        new
                        {
                            StateParkId = 27,
                            County = "Calaveras",
                            Name = "Calaveras Big Trees State Park",
                            State = "California"
                        },
                        new
                        {
                            StateParkId = 28,
                            County = "Riverside",
                            Name = "California Citrus State Historic Park",
                            State = "California"
                        },
                        new
                        {
                            StateParkId = 29,
                            County = "San Luis Obispo",
                            Name = "California State Marine Park",
                            State = "California"
                        },
                        new
                        {
                            StateParkId = 30,
                            County = "San Diego",
                            Name = "Cardiff State Beach",
                            State = "California"
                        },
                        new
                        {
                            StateParkId = 31,
                            County = "Shasta",
                            Name = "Castle Crags State Park",
                            State = "California"
                        },
                        new
                        {
                            StateParkId = 32,
                            County = "San Joaquin",
                            Name = "Caswell Memorial State Park",
                            State = "California"
                        },
                        new
                        {
                            StateParkId = 33,
                            County = "Marin",
                            Name = "China Camp State Park",
                            State = "California"
                        },
                        new
                        {
                            StateParkId = 34,
                            County = "Yellowstone",
                            Name = "Lake Elemo State Park",
                            State = "Montana"
                        },
                        new
                        {
                            StateParkId = 35,
                            County = "Lake",
                            Name = "Lake Mary Ronan State Park",
                            State = "Montana"
                        },
                        new
                        {
                            StateParkId = 36,
                            County = "Jefferson",
                            Name = "Lewis and Clark Caverns State Park",
                            State = "Montana"
                        },
                        new
                        {
                            StateParkId = 37,
                            County = "Flathead",
                            Name = "Lone Pine State Park",
                            State = "Montana"
                        },
                        new
                        {
                            StateParkId = 38,
                            County = "Deer Lodge",
                            Name = "Lost Creek State Park",
                            State = "Montana"
                        },
                        new
                        {
                            StateParkId = 39,
                            County = "Missoula",
                            Name = "Milltown State Park",
                            State = "Montana"
                        },
                        new
                        {
                            StateParkId = 40,
                            County = "Gallatin",
                            Name = "Missouri Headwaters State Park",
                            State = "Montana"
                        },
                        new
                        {
                            StateParkId = 41,
                            County = "Missoula",
                            Name = "Salmon Lake State Park",
                            State = "Montana"
                        },
                        new
                        {
                            StateParkId = 42,
                            County = "Lewis and Clark",
                            Name = "Spring Meadow Lake State Park",
                            State = "Montana"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
