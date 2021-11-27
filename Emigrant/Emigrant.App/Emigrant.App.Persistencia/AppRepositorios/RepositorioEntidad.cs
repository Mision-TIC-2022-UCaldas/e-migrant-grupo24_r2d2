using System;
using Emigrant.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Emigrant.App.Persistencia
{
    public class RepositorioEntidad : IRepositorioEntidad
    {
        private readonly AppContext _appContext;

        public RepositorioEntidad(AppContext appContext)
        {
            _appContext = appContext;
        }
        
        Entidad IRepositorioEntidad.AddEntidad(Entidad entidad)
        {
            var entidadAdicionado = _appContext.entidades.Add(entidad);
            _appContext.SaveChanges();
            return entidadAdicionado.Entity;
        }
    }
}