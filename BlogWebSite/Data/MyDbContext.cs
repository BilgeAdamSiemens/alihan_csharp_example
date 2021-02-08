using Entity;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class MyDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Message> Messages { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options): base(options)
        {
            
        }

        public MyDbContext():this(new DbContextOptionsBuilder<MyDbContext>().UseSqlite("Data Source=../blog.db").Options)
        {
            
        }
    }
}