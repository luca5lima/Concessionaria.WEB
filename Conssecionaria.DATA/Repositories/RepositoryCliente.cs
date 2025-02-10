using Conssecionaria.DATA.Interfaces;
using Conssecionaria.DATA.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conssecionaria.DATA.Repositories
{
    public class RepositoryCliente : RepositoryBase<Cliente>, IRepositoryCliente
    {
        public RepositoryCliente(bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }
}
