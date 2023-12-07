using Lab_1___PH29972.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab_1___PH29972.Context
{
    public class MyDBContext:DbContext
    {
        public MyDBContext(DbContextOptions options): base(options)
        {

        }

       public DbSet<Movie> movies { get; set; }
    }
}
