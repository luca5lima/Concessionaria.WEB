using Conssecionaria.DATA.Models;
using Conssecionaria.DATA.Services;
using Microsoft.AspNetCore.Mvc;

namespace Concessionariaa.Web.Controllers
{
    public class ClienteController : Controller
    {
        private ClienteService oClienteService = new ClienteService();

        public IActionResult Index()
        {
            List<Cliente> oListCliente = oClienteService.oRepositoryCliente.SelectAll();

            return View(oListCliente);
        }

        public IActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Cliente model) 
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            oClienteService.oRepositoryCliente.Creat(model);

            return RedirectToAction("index");
        }
    }
}
