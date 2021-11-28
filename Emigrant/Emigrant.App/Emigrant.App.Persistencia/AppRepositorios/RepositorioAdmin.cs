using System;
using Emigrant.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Emigrant.App.Persistencia
{
    public class RepositorioAdmin : IRepositorioAdmin
    {
        private readonly AppContext _appContext;

        public RepositorioAdmin(AppContext appContext)
        {
            _appContext = appContext;
        }
        Admin IRepositorioAdmin.StartSession(string Correo, string Contrasena) {             
            var AdminEncontrado = _appContext.administrador.FirstOrDefault(g => g.Correo == Correo && g.Cotrasena == Contrasena);
            return AdminEncontrado;
        }
        
        Entidad IRepositorioAdmin.CancelarCuentaEntidad(int idEntidad)
        {
            var entidadEncontrada = _appContext.entidades.FirstOrDefault(g => g.Id == idEntidad);
            if(entidadEncontrada != null){
                entidadEncontrada.estado = "cancelado";
                _appContext.SaveChanges();
            }

            return entidadEncontrada;
        }


        Migrante IRepositorioAdmin.CancelarCuentaMigrante(int idMigrante)
        {
            var migranteEncontrado = _appContext.migrantes.FirstOrDefault(g => g.Id == idMigrante);
            if(migranteEncontrado != null){
                migranteEncontrado.estado = "cancelado";
                _appContext.SaveChanges();
            }
            
            return migranteEncontrado;
        }

        Gerente IRepositorioAdmin.CancelarCuentaGerente(int idGerente)
        {
            var gerenteEncontrado = _appContext.gerentes.FirstOrDefault(g => g.Id == idGerente);
            if(gerenteEncontrado != null){
                gerenteEncontrado.estado = "cancelado";
                _appContext.SaveChanges();
            }
            
            return gerenteEncontrado;
        }
    }
}