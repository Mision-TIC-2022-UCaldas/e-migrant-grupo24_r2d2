using Emigrant.App.Dominio;
using System.Collections.Generic;


namespace Emigrant.App.Persistencia
{
    public interface IRepositorioEntidad
    {
        Entidad AddEntidad(Entidad entidad);
        Entidad StartSession(string Correo, string Contrasena);
        bool SearchCorreoEntidad(string correo);
        bool SearchNITEntidad(string nit);
    }
}
