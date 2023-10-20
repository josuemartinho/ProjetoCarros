using Microsoft.AspNetCore.Mvc;
using ProjetoCarros.Data;
using ProjetoCarros.Models;

namespace ProjetoCarros.Controllers
{
    public class RegistoCarrosController : Controller
    {
		readonly private ApplicationDBContext _db;
		public RegistoCarrosController(ApplicationDBContext db)
		{
			_db = db;
		}
		public IActionResult Index()
		{
			IEnumerable<RegistoModel> registos = _db.RegistosCarros;
			return View(registos);
		}
		[HttpGet]
		public IActionResult NovoRegisto()
		{
			return View();
		}
		[HttpPost]
		public IActionResult NovoRegisto(RegistoModel registos)
		{
			if (ModelState.IsValid)
			{
				_db.RegistosCarros.Add(registos);
				_db.SaveChanges();
				return RedirectToAction("Index");

			}
			return View();
		}
	}
}

