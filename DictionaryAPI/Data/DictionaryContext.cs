using Microsoft.EntityFrameworkCore;
using DictionaryAPI.Models;

namespace DictionaryAPI.Data
{
    public class DictionaryContext : DbContext
    {
        public DictionaryContext(DbContextOptions<DictionaryContext> options) : base(options) { }

        public DbSet<DictionaryEntry> Dictionary { get; set; }
    }
}
