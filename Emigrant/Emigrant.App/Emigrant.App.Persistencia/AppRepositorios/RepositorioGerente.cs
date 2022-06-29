using System;
using Emigrant.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Emigrant.App.Persistencia
{
    public class RepositorioGerente : IRepositorioGerente
    {
        private readonly AppContext _appContext;

        public RepositorioGerente(AppContext appContext)
        {
            _appContext = appContext;
        }

        IEnumerable<Gerente> IRepositorioGerente.GetAllGerentes() {
            return _appContext.gerentes;
        }

        Gerente IRepositorioGerente.StartSession(string Correo, string Contrasena) {             
            var gerenteEncontrado = _appContext.gerentes.FirstOrDefault(g => g.Correo == Correo && g.Contrasena == Contrasena );
            
            if(gerenteEncontrado != null && gerenteEncontrado.estado == "habilitado")
                return gerenteEncontrado;
            else
                return null;
        }
    }
}