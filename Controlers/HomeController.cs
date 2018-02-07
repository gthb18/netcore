using Microsoft.AspNetCore.Mvc;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        // GET
        public string Index()
        {
            return "Hello";
        }
    }
}