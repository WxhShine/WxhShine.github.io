using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace EFDemo {
    public class UserContext :DbContext{
        public UserContext() : base("EFDemoConnectionString") { }

        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
