using Microsoft.EntityFrameworkCore;

namespace WpfApp1.EF
{
    internal class MonProjetDBcontext : DbContext
    {
        public DbSet<CollaborateurModel> Collaborateurs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(@"server=localhost;database=monprojet;user=root;password=");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CollaborateurModel>(entity =>
            {
                entity.HasKey(e => e.IdCollaborateur);
            });
        }
    }
}
