using Emigrant.App.Dominio;
using System.Collections.Generic;


namespace Emigrant.App.Persistencia
{
    public interface IRepositorioServicios
    {
        Servicio AddServicio(Servicio servicio);
        IEnumerable<Servicio> GetAllServicios();
        IEnumerable<Servicio> GetServicioByCategoria(string Categoria);

    }
}
