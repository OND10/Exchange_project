using Microsoft.EntityFrameworkCore;

namespace Exchange_project.DTO
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            

        }

        

    }
}
