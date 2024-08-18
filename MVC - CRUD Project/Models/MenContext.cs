using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace MVC___CRUD_Project.Models
{
    public class MenContext : DbContext
    {
        public MenContext(DbContextOptions options) : base(options) { }

        public DbSet<Men> Mens { get; set; }

       

    }
}
