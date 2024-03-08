using Microsoft.EntityFrameworkCore;

namespace BookStore.API.Models
{
    public class DBContextBookStore:DbContext
    {
        public DBContextBookStore(DbContextOptions<DBContextBookStore> options)
            :base(options)
        {
            
        }
        public DbSet<Book> books { get; set; }
    }
}
