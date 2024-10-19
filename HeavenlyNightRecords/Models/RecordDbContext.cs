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
            modelBuilder.Entity<Records>().HasData(
                new Records
                {
                    Id = 1,
                    Artist = "Childish Gambino",
                    Album = "Awaken, My Love!",
                    Genre = "RnB",
                    year = 2016,
                    Price = 20
                },
                new Records
                {
                    Id = 2,
                    Artist = "Alicia Keys",
                    Album = "Songs in A Minor",
                    Genre = "RnB",
                    year = 2001,
                    Price = 20
                }, new Records
                {
                    Id = 3,
                    Artist = "Kendrick Lamar",
                    Album = "Good Kid, M.A.A.D City",
                    Genre = "Rap",
                    year = 2011,
                    Price = 20
                }, new Records
                {
                    Id = 4,
                    Artist = "MF DOOM",
                    Album = "Operation: Doomsday",
                    Genre = "Rap",
                    year = 1999,
                    Price = 20
                }, new Records
                {
                    Id = 5,
                    Artist = "The Beatles",
                    Album = "Abbey Road",
                    Genre = "Rock",
                    year = 1969,
                    Price = 20
                },
                new Records
                {
                    Id = 6,
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
                    Album = "Seasons in the Abyss",
                    Genre = "Metal",
                    year = 1990,
                    Price = 20
                },
                new Records
                {
                    Id = 8,
                    Artist = "Blackbraid",
                    Album = "Blackbraid I",
                    Genre = "Metal",
                    year = 2022,
                    Price = 20
                },
                new Records
                {
                    Id = 9,
                    Artist = "Chet Baker",
                    Album = "Chet Baker Sings",
                    Genre = "Jazz",
                    year = 1954,
                    Price = 20
                },
                new Records
                {
                    Id = 10,
                    Artist = "Duke Ellington & John Coltrane",
                    Album = "The Duke Ellington & John Coltrane Album",
                    Genre = "Jazz",
                    year = 1963,
                    Price = 20
                },
                new Records
                {
                    Id = 11,
                    Artist = "Ryo Fukui",
                    Album = "Scenery",
                    Genre = "Jazz",
                    year = 1976,
                    Price = 20
                },
                new Records
                {
                    Id = 12,
                    Artist = "Lady Gaga",
                    Album = "The Fame",
                    Genre = "Pop",
                    year = 2008,
                    Price = 20
                },
                new Records
                {
                    Id = 13,
                    Artist = "Wham!",
                    Album = "Make It Big",
                    Genre = "Pop",
                    year = 1984,
                    Price = 20
                },
                new Records
                {
                    Id = 14,
                    Artist = "Chris Stapleton",
                    Album = "Traveller",
                    Genre = "Country",
                    year = 2015,
                    Price = 20
                }, new Records
                {
                    Id = 15,
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
    