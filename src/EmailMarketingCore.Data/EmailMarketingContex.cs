namespace EmailMarketingCore.Data
{
    using EmailMarketingCore.Domain;
    using Microsoft.EntityFrameworkCore;

    public class EmailMarketingContex : DbContext
    {
        public DbSet<Town> Towns { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<SchoolClass> SchoolClasses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = EmailMarketing; Trusted_Connection = True; ");
        }
    }
}
