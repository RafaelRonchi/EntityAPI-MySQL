using APImysqlTest.Model;
using Microsoft.EntityFrameworkCore;

namespace APImysqlTest.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }
        public DbSet<testCsharp> testcrud { get; set; }
    }
}
