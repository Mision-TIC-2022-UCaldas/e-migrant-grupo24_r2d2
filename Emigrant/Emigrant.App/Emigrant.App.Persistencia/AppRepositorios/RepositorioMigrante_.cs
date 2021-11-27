using System;
using Emigrant.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Emigrant.App.Persistencia
{
    public class RepositorioMigrante_ : IRepositorioMigrante_
    {
        private readonly AppContext _appContext;

        public RepositorioMigrante_(AppContext appContext)
        {
            _appContext = appContext;
        }
        
        Migrante_ IRepositorioMigrante_.AddMigrante(Migrante_ migrante)
        {
            var migranteAdicionado = _appContext.migrantes.Add(migrante);
            _appContext.SaveChanges();
            return migranteAdicionado.Entity;
        }
    }
}