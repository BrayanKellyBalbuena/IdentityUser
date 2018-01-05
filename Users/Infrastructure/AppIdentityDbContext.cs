using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using Users.Models;
using Microsoft.AspNet.Identity;

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

        public class IdentityDbInit : NullDatabaseInitializer<AppIdentityDbContext>
        {
          
        }

    }
}