using WebApplication1.Models;
using Microsoft.EntityFrameworkCore;


namespace WebApplication1.Data
{

    public class AppDBContext(DbContextOptions<AppDBContext> options) : DbContext(options)
    {

        public DbSet<User> Users { get; set; }

    }
      
}
