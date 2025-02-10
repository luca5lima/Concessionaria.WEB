using Conssecionaria.DATA.Models;
using Conssecionaria.DATA.Services;
using Microsoft.AspNetCore.Mvc;

namespace Concessionaria.WEB.Controllers
{
    public class MotoController : Controller
    {
        private MotoService oMotoService = new MotoService();

        public IActionResult Index()
        {
            List<Moto> oListMoto = oMotoService.oRepositoryMoto.SelectAll();

            return View(oListMoto);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Moto moto)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            oMotoService.oRepositoryMoto.Creat(moto);

            return RedirectToAction("Index");
        }
    }
}
