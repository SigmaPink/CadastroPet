using Microsoft.EntityFrameworkCore;

namespace CadPet.Models
{
    public class CadAnimalContext : DbContext 
    {
        public CadAnimalContext(DbContextOptions<CadAnimalContext> options)
            : base(options)
        {
            //Default
        }

        public DbSet<CadAnimal> CadAnimal { get; set; }
    }
}