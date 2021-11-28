using System;
using Emigrant.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Emigrant.App.Persistencia
{
    public class RepositorioAF : IRepositorioAF
    {
        private readonly AppContext _appContext;

        public RepositorioAF(AppContext appContext)
        {
            _appContext = appContext;
        }
        
    }
}