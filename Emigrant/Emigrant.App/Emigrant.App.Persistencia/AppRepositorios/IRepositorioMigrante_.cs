using Emigrant.App.Dominio;
using System.Collections.Generic;


namespace Emigrant.App.Persistencia
{
    public interface IRepositorioMigrante
    {
        Migrante AddMigrante(Migrante migrante);

        IEnumerable<Migrante> GetAllMigrantes();
        bool SearchCorreoMigrante(string correo);
        bool SearchDocumentoMigrante(string documento);
        Migrante StartSession(string Correo, string Contrasena);
    }
}
