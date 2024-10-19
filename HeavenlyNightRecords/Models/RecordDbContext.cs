using Microsoft.EntityFrameworkCore;

namespace HeavenlyNightRecords.Models
{
    public class RecordDbContext : DbContext
    {
        public RecordDbContext(DbContextOptions<RecordDbContext> options) {}

    }
}
