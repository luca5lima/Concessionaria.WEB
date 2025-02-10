using Conssecionaria.DATA.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conssecionaria.DATA.Services
{
    public class ChecagemService
    {
        public RepositoryChecagem oRepositoryChecagem { get; set; }

        public ChecagemService() 
        {
            oRepositoryChecagem = new RepositoryChecagem();
        }
    }
}
