using Microsoft.AspNetCore.Mvc;

namespace authForm.Controllers
{

    public class HomeController : Controller
    {
        
        public string Index()
        {
            return "Сайт для гостиницы";
        }
    }
}