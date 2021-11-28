using Emigrant.App.Dominio;
using System.Collections.Generic;


namespace Emigrant.App.Persistencia
{
    public interface IRepositorioAdmin
    {
        Entidad CancelarCuentaEntidad(int idEntidad);
        Migrante CancelarCuentaMigrante(int idMigrante);

        Admin StartSession(string Correo, string Contrasena);

        //Entidad StartSession(string Correo, string Contrasena);
        //bool SearchCorreoEntidad(string correo);
        //bool SearchNITEntidad(string nit);
    }
}
