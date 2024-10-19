namespace HeavenlyNightRecords.Models
{
    public class Records
    {
        public int Id { get; set; }
        public string Artist { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
    public class Genres
    {
        public int Id { get; set; }
        public string? Rock { get; set; }
        public string? Metal { get; set; }
        public string? Jazz { get; set; }
        public string? Blues { get; set; }
        public string? HipHop { get; set; }
        public string? RnB { get; set; }
        public string? Country { get; set; }
    }
}
