using Emigrant.App.Dominio;
using System.Collections.Generic;


namespace Emigrant.App.Persistencia
{
    public interface IRepositorioEntidad
    {
        Entidad AddEntidad(Entidad entidad);
        IEnumerable<Entidad> GetAllEntidades();
        
        Entidad GetEntidadByID(int idEntidad);
        Entidad StartSession(string Correo, string Contrasena);
        bool SearchCorreoEntidad(string correo);
        bool SearchNITEntidad(string nit);
        bool UpdateCredencialesEntidad(Entidad entidad, string ContrasenaA);
        Entidad UpdateEntidad(Entidad entidad);
    }
}
