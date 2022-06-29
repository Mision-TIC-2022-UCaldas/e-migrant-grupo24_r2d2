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

        Servicio IRepositorioServicios.AddServicio(Servicio servicio)
        {
            var servicioAdicionado = _appContext.servicios.Add(servicio);
            _appContext.SaveChanges();
            return servicioAdicionado.Entity;
        }

        IEnumerable<Servicio> IRepositorioServicios.GetAllServicios() {
            return _appContext.servicios;
        }

        IEnumerable<Servicio> IRepositorioServicios.GetServicioByCategoria(string categoria){
            return _appContext.servicios.Where(s => s.Categoria == categoria).ToList();            
            
        }
        
    }
}