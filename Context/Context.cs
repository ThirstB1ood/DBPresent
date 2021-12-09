using DatabaseModels.Certificates;
using DatabaseModels.Doctors;
using DatabaseModels.Specializations;
using Microsoft.EntityFrameworkCore;

namespace DatabaseContext
{
    public class ContextDB : DbContext
    {
        private static readonly string connectionString = "User ID=postgres;Password=Soldat1941;Server=localhost;Port=5432;Database=PresentationDB;";
        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<Certificate> Certificates { get; set; }

        public DbSet<Specialization> Specializations { get; set; }

        public ContextDB() : base(GetOptions(connectionString))
        {

        }

        private static DbContextOptions GetOptions(string connectionString)
        {
            DbContextOptionsBuilder<ContextDB> optionsBuilder = new();
            optionsBuilder.UseNpgsql(connectionString);
            return optionsBuilder.Options;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>().Property("SpecializationId").IsRequired();
            modelBuilder.Entity<Doctor>().Property("Name").IsRequired();

            modelBuilder.Entity<Certificate>().Property("Description").IsRequired();
            modelBuilder.Entity<Certificate>().Property("Date").IsRequired();
            modelBuilder.Entity<Certificate>().Property("DoctorId").IsRequired();


            modelBuilder.Entity<Specialization>().Property("Name").IsRequired();

            modelBuilder.Entity<Doctor>()
                .HasMany(t => t.Certificates)
                .WithOne(t => t.Doctor)
                .IsRequired(true)
                .HasForeignKey(t => t.DoctorId);

            modelBuilder.Entity<Certificate>();

            modelBuilder.Entity<Specialization>()
                .HasMany(t => t.Doctors)
                .WithOne(t => t.Specialization)
                .IsRequired(true);

            base.OnModelCreating(modelBuilder);
        }
    }
}