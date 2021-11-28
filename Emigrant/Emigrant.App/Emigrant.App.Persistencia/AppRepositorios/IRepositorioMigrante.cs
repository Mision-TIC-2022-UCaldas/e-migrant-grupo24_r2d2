using Emigrant.App.Dominio;
using System.Collections.Generic;


namespace Emigrant.App.Persistencia
{
    public interface IRepositorioMigrante
    {
        Migrante AddMigrante(Migrante migrante);

        IEnumerable<Migrante> GetAllMigrantes();
        Migrante GetMigranteByID(int idMigrante);
        bool SearchCorreoMigrante(string correo);
        bool SearchDocumentoMigrante(string documento);
        Migrante StartSession(string Correo, string Contrasena);

        Migrante UpdateMigrante(Migrante migrante);
        bool UpdateCredencialesMigrante(Migrante migrante, string ContrasenaA);
    }
}
