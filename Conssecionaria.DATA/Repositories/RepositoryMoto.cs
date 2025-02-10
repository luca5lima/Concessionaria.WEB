using Conssecionaria.DATA.Interfaces;
using Conssecionaria.DATA.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conssecionaria.DATA.Repositories
{
    public class RepositoryMoto : RepositoryBase<Moto>, IRepositoryMoto
    {
        public RepositoryMoto(bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }
}
