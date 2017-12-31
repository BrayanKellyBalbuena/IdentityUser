using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using Users.Models;

namespace Users.Infrastructure
{
    public class AppIdentityDbContext : IdentityDbContext<AppUser>
    {
        public AppIdentityDbContext() : base("IdendityDb",throwIfV1Schema: false) {
#if DEV
            Database.Log = sql => System.Diagnostics.Debug.WriteLine(sql);
#endif
        }

        static AppIdentityDbContext() => Database.SetInitializer(new IdentityDbInit());

        public static AppIdentityDbContext Create() => new AppIdentityDbContext();

        public class IdentityDbInit : DropCreateDatabaseIfModelChanges<AppIdentityDbContext>
        {
            protected override void Seed(AppIdentityDbContext context)
            {
                PerformInitialSetup(context);
                base.Seed(context);
            }

            public void PerformInitialSetup(AppIdentityDbContext context)
            {

            }
        }

    }
}