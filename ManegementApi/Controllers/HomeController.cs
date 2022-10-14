using Microsoft.AspNetCore.Mvc;

namespace ManegementApi.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Home";
        }
    }
}
