using Conssecionaria.DATA.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conssecionaria.DATA.Services
{
    public class MotoService
    {
        public RepositoryMoto oRepositoryMoto {  get; set; }

        public MotoService() 
        {
            oRepositoryMoto = new RepositoryMoto();
        }
    }
}
