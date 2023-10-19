using Microsoft.AspNetCore.Mvc;

namespace ProjetoCarros.Controllers
{
    public class RegistoCarrosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
