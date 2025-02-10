using Conssecionaria.DATA.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conssecionaria.DATA.Services
{
    public class ClienteService
    {
        public RepositoryCliente oRepositoryCliente {  get; set; }

        public ClienteService()
        {
            oRepositoryCliente = new RepositoryCliente();
        }
    }
}
