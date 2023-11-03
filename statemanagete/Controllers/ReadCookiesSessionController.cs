using Microsoft.AspNetCore.Mvc;

namespace statemanagete.Controllers
{
    public class ReadCookieSessionController : Controller
    {
        private readonly IHttpContextAccessor _httpcontextAccessor;

        public ReadCookieSessionController(IHttpContextAccessor httpcontextAccessor)
        {
            _httpcontextAccessor = httpcontextAccessor;
        }

        public IActionResult ReadCookie()
        {
            if (_httpcontextAccessor.HttpContext != null)
            {
                //read value from cookie
                ViewBag.Email = _httpcontextAccessor.HttpContext.Request.Cookies["email"];
            }
            return View();
        }
        public IActionResult ReadSession()
        {
            ViewBag.Email = HttpContext.Session.GetString("email");
            //string role=HttpContext.Session.GetString("roleId");
            return View();
        }

    }
}

