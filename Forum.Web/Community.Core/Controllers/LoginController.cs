using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace Community.Core.Controllers
{
    public class LoginController : SurfaceController
    {
        public ActionResult Login()
        {

            return PartialView("_Login", model);
        }
    }
}
