using System.Web;
using System.Web.Mvc;
using Users.Infrastructure;
using Microsoft.AspNet.Identity.Owin;

namespace Users.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index() => View(UserManager.Users);

        private AppUserManager UserManager => HttpContext.GetOwinContext().Get<AppUserManager>();
    }
}