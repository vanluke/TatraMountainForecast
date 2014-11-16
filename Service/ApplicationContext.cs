using Model.Implementation;
using System.Data.Entity;

namespace Service
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext()
            : base("name=DefaultConnection")
        {
            this.Configuration.LazyLoadingEnabled = true;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ApplicationUserLogin>().HasKey(m => m.LoginProvider).HasKey(m => m.ProviderKey).ToTable("Logins");
            modelBuilder.Entity<ApplicationUserClaim>().HasKey(m => m.Id).ToTable("UserClaims");
            modelBuilder.Entity<ApplicationRole>().HasKey(m => m.Id).ToTable("Roles");
            modelBuilder.Entity<ApplicationUserRole>().HasKey(m => m.RoleId).HasKey(m => m.UserId).ToTable("UserRoles");
            modelBuilder.Entity<ApplicationUser>().ToTable("Users");
        }

        public static ApplicationContext Create()
        {
            return new ApplicationContext();
        }
        public DbSet<ApplicationUserRole> UserRoles { get; set; }
        public DbSet<ApplicationUser> Users { get; set; }
        public DbSet<ApplicationRole> Roles { get; set; }
        public DbSet<ApplicationUserClaim> UserClaims { get; set; }
        public DbSet<ApplicationUserLogin> UserLogins { get; set; }

    }
}
