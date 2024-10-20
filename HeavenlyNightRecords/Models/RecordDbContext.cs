using Microsoft.EntityFrameworkCore;

namespace HeavenlyNightRecords.Models
{
    public class RecordDbContext : DbContext
    {
        public RecordDbContext
          (DbContextOptions<RecordDbContext> options) : base(options)
        { }
        public DbSet<Records> Record { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            _ = modelBuilder.Entity<Records>().HasData(
                new Records
                {
                    Id = 1,
                    Cover = "/Albums Covers/RnB/AML.png",
                    Artist = "Childish Gambino",
                    Album = "Awaken, My Love!",
                    Genre = "RnB",
                    year = 2016,
                    Price = 20
                },
                new Records
                {
                    Id = 2,
                    Cover = "/Albums Covers/RnB/SIM.png",
                    Artist = "Alicia Keys",
                    Album = "Songs in A Minor",
                    Genre = "RnB",
                    year = 2001,
                    Price = 20
                }, new Records
                {
                    Id = 3,
                    Cover = "/Albums Covers/Rap/MAAD.png",
                    Artist = "Kendrick Lamar",
                    Album = "Good Kid, M.A.A.D City",
                    Genre = "Rap",
                    year = 2011,
                    Price = 20
                }, new Records
                {
                    Id = 4,
                    Cover = "/Albums Covers/Rap/OPDD.png",
                    Artist = "MF DOOM",
                    Album = "Operation: Doomsday",
                    Genre = "Rap",
                    year = 1999,
                    Price = 20
                }, new Records
                {
                    Id = 5,
                    Cover = "/Albums Covers/Rock/AR.png",
                    Artist = "The Beatles",
                    Album = "Abbey Road",
                    Genre = "Rock",
                    year = 1969,
                    Price = 20
                },
                new Records
                {
                    Id = 6,
                    Cover = "/Albums Covers/Rock/DSOM.png",
                    Artist = "Pink Floyd",
                    Album = "The Dark Side of the Moon",
                    Genre = "Rock",
                    year = 1973,
                    Price = 20
                },
                new Records
                {
                    Id = 7,
                    Artist = "Slayer",
                    Cover = "/Albums Covers/Metal/SITA.png",
                    Album = "Seasons in the Abyss",
                    Genre = "Metal",
                    year = 1990,
                    Price = 20
                },
                new Records
                {
                    Id = 8,
                    Cover = "/Albums Covers/Metal/BB.png",
                    Artist = "Blackbraid",
                    Album = "Blackbraid I",
                    Genre = "Metal",
                    year = 2022,
                    Price = 20
                },
                new Records
                {
                    Id = 9,
                    Cover = "/Albums Covers/Jazz/CB.png",
                    Artist = "Chet Baker",
                    Album = "Chet Baker Sings",
                    Genre = "Jazz",
                    year = 1954,
                    Price = 20
                },
                new Records
                {
                    Id = 10,
                    Cover = "/Albums Covers/Jazz/DEJC.png",
                    Artist = "Duke Ellington & John Coltrane",
                    Album = "The Duke Ellington & John Coltrane Album",
                    Genre = "Jazz",
                    year = 1963,
                    Price = 20
                },
                new Records
                {
                    Id = 11,
                    Cover = "/Albums Covers/Jazz/S.png",
                    Artist = "Ryo Fukui",
                    Album = "Scenery",
                    Genre = "Jazz",
                    year = 1976,
                    Price = 20
                },
                new Records
                {
                    Id = 12,
                    Cover = "/Albums Covers/Pop/FAME.png",
                    Artist = "Lady Gaga",
                    Album = "The Fame",
                    Genre = "Pop",
                    year = 2008,
                    Price = 20
                },
                new Records
                {
                    Id = 13,
                    Cover = "/Albums Covers/Pop/MIB.png",
                    Artist = "Wham!",
                    Album = "Make It Big",
                    Genre = "Pop",
                    year = 1984,
                    Price = 20
                },
                new Records
                {
                    Id = 14,
                    Cover = "/Albums Covers/Country/CST.png",
                    Artist = "Chris Stapleton",
                    Album = "Traveller",
                    Genre = "Country",
                    year = 2015,
                    Price = 20
                },
                new Records
                {
                    Id = 15,
                    Cover = "/Albums Covers/Country/BOI.png",
                    Artist = "Johnny Cash",
                    Album = "Bitter Tears: Ballads of the American Indian",
                    Genre = "Country",
                    year = 1964,
                    Price = 20
                }
                );
        }
    }
}
    