using System.Web.Mvc;
using MusicPortalBLL.Services.Database;



namespace MusicPortal.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            try
            {
                var userService = new UserService();
                userService.GetUsers();
                ViewBag.DatabaseConnectionError = false;
            }
            catch
            {
                ViewBag.DatabaseConnectionError = true;
            }

            return View();
        }
    }
}