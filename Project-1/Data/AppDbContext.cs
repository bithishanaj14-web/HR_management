using Microsoft.EntityFrameworkCore;

namespace Project_1.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions option)
            :base(option)
        {

        }
    }
}
