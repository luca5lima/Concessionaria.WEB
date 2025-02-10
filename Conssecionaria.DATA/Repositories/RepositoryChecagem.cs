using Conssecionaria.DATA.Interfaces;
using Conssecionaria.DATA.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conssecionaria.DATA.Repositories
{
    public class RepositoryChecagem : RepositoryBase<Checagem>, IRepositoryChecagem
    {
        public RepositoryChecagem(bool SaveChanges = true) : base(SaveChanges)
        {
        
        }
    }
}
