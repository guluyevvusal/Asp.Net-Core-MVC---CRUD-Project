using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace MVC___CRUD_Project.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions options) : base(options) { }

        public DbSet<Product> Products { get; set; }

       

    }
}
