using ApiPapeterie.models;
using Microsoft.EntityFrameworkCore;

namespace ApiPapeterie.data
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Produit> Produits { get; set; }
    }
}
