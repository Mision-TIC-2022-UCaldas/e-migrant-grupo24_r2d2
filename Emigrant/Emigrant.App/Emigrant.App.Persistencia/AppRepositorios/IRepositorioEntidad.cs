using Emigrant.App.Dominio;
using System.Collections.Generic;


namespace Emigrant.App.Persistencia
{
    public interface IRepositorioEntidad
    {
        Entidad AddEntidad(Entidad entidad);
    }
}
