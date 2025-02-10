using Conssecionaria.DATA.Models;
using Conssecionaria.DATA.Services;
using Microsoft.AspNetCore.Mvc;

namespace Concessionaria.WEB.Controllers
{
    public class ChecagemController : Controller
    {
        private ChecagemService oChecagemService = new ChecagemService();

        public IActionResult Index()
        {
            List<Checagem> oListChecagem = oChecagemService.oRepositoryChecagem.SelectAll();

            return View(oListChecagem);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Checagem model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            oChecagemService.oRepositoryChecagem.Creat(model);

            return RedirectToAction("Index");
        }
    }
}
