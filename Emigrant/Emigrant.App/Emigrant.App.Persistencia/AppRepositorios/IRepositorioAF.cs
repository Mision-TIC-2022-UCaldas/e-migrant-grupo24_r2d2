using Emigrant.App.Dominio;
using System.Collections.Generic;


namespace Emigrant.App.Persistencia
{
    public interface IRepositorioAF
    {
        AF AddAmigo(AF af);
        AF AddFamiliar(AF af);
        // IEnumerable<AF> GetAFbyId(int id);
    }
}
