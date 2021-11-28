using System;
using Emigrant.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Emigrant.App.Persistencia
{
    public class RepositorioMigrante : IRepositorioMigrante
    {
        private readonly AppContext _appContext;

        public RepositorioMigrante(AppContext appContext)
        {
            _appContext = appContext;
        }
        
        Migrante IRepositorioMigrante.AddMigrante(Migrante migrante)
        {
            var migranteAdicionado = _appContext.migrantes.Add(migrante);
            _appContext.SaveChanges();
            return migranteAdicionado.Entity;
        }

        IEnumerable<Migrante> IRepositorioMigrante.GetAllMigrantes() {
            return _appContext.migrantes;
        }

        Migrante IRepositorioMigrante.StartSession(string Correo, string Contrasena) {             
            var MigranteEncontrado = _appContext.migrantes.FirstOrDefault(g => g.Correo == Correo && g.Contrasena == Contrasena);
            
            if(MigranteEncontrado != null && MigranteEncontrado.estado == "habilitado")
                return MigranteEncontrado;
            else
                return null;
        }
        bool IRepositorioMigrante.SearchCorreoMigrante(string correo){
            var migranteEncontrado = _appContext.migrantes.FirstOrDefault(g => g.Correo == correo);
            
            if(migranteEncontrado != null)
                return true;
            else
                return false;
        }
        bool IRepositorioMigrante.SearchDocumentoMigrante(string documento){
            var migranteEncontrado = _appContext.migrantes.FirstOrDefault(g => g.Documento == documento);
            
            if(migranteEncontrado != null)
                return true;
            else
                return false;

        }
    }
}