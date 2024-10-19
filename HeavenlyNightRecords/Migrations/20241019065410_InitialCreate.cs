using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HeavenlyNightRecords.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Record",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Artist = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Album = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    year = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Record", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Record",
                columns: new[] { "Id", "Album", "Artist", "Genre", "Price", "year" },
                values: new object[,]
                {
                    { 1, "Awaken, My Love!", "Childish Gambino", "RnB", 20m, 2016 },
                    { 2, "Songs in A Minor", "Alicia Keys", "RnB", 20m, 2001 },
                    { 3, "Good Kid, M.A.A.D City", "Kendrick Lamar", "Rap", 20m, 2011 },
                    { 4, "Operation: Doomsday", "MF DOOM", "Rap", 20m, 1999 },
                    { 5, "Abbey Road", "The Beatles", "Rock", 20m, 1969 },
                    { 6, "The Dark Side of the Moon", "Pink Floyd", "Rock", 20m, 1973 },
                    { 7, "Seasons in the Abyss", "Slayer", "Metal", 20m, 1990 },
                    { 8, "Blackbraid I", "Blackbraid", "Metal", 20m, 2022 },
                    { 9, "Chet Baker Sings", "Chet Baker", "Jazz", 20m, 1954 },
                    { 10, "The Duke Ellington & John Coltrane Album", "Duke Ellington & John Coltrane", "Jazz", 20m, 1963 },
                    { 11, "Scenery", "Ryo Fukui", "Jazz", 20m, 1976 },
                    { 12, "The Fame", "Lady Gaga", "Pop", 20m, 2008 },
                    { 13, "Make It Big", "Wham!", "Pop", 20m, 1984 },
                    { 14, "Traveller", "Chris Stapleton", "Country", 20m, 2015 },
                    { 15, "Bitter Tears: Ballads of the American Indian", "Johnny Cash", "Country", 20m, 1964 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Record");
        }
    }
}
