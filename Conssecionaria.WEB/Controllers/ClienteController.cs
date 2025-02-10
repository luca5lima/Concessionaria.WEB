using Conssecionaria.DATA.Models;
using Conssecionaria.DATA.Services;
using Microsoft.AspNetCore.Mvc;

namespace Conssecionaria.WEB.Controlleres
{
    public class ClienteController : Controller
    {
        private ClienteService oClienteService = new ClienteService();

        public IActionResult Index()
        {
            List<Cliente> oListCliente = oClienteService.oRepositoryCliente.SelectAll();

            return View(oListCliente);
        }
    }
}
