using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Users.Infrastructure
{
    public class AppRole : IdentityRole
    {
        public int MyProperty { get; set; }
    }
}