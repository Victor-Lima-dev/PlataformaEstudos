using Microsoft.EntityFrameworkCore;

namespace PlataformaEstudos.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }
}
