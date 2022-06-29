using Emigrant.App.Dominio;
using System.Collections.Generic;


namespace Emigrant.App.Persistencia
{
    public interface IRepositorioGerente
    {
        
        IEnumerable<Gerente> GetAllGerentes();
        Gerente StartSession(string Correo, string Contrasena);
        //bool SearchCorreoEntidad(string correo);
        
    }
}
