using Emigrant.App.Dominio;
using System.Collections.Generic;


namespace Emigrant.App.Persistencia
{
    public interface IRepositorioMigrante_
    {
        Migrante_ AddMigrante(Migrante_ migrante);
        bool SearchCorreoMigrante(string correo);
        bool SearchDocumentoMigrante(string documento);
    }
}
