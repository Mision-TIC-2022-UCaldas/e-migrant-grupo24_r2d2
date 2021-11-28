using System;
using Emigrant.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Emigrant.App.Persistencia
{
    public class RepositorioServicios : IRepositorioServicios
    {
        private readonly AppContext _appContext;

        public RepositorioServicios(AppContext appContext)
        {
            _appContext = appContext;
        }
        
    }
}