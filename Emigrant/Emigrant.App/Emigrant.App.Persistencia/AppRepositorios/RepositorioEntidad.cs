using System;
using Emigrant.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Emigrant.App.Persistencia
{
    public class RepositorioEntidad : IRepositorioEntidad
    {
        private readonly AppContext _appContext;

        public RepositorioEntidad(AppContext appContext)
        {
            _appContext = appContext;
        }

        IEnumerable<Entidad> IRepositorioEntidad.GetAllEntidades() {
            return _appContext.entidades;
        }
        
        Entidad IRepositorioEntidad.AddEntidad(Entidad entidad)
        {
            var entidadAdicionado = _appContext.entidades.Add(entidad);
            _appContext.SaveChanges();
            return entidadAdicionado.Entity;
        }

        Entidad IRepositorioEntidad.StartSession(string Correo, string Contrasena) {             
            var EntidadEncontrado = _appContext.entidades.FirstOrDefault(g => g.Correo == Correo && g.Contrasena == Contrasena );
            return EntidadEncontrado;
        }

        bool IRepositorioEntidad.SearchCorreoEntidad(string correo){
            var entidadEncontrada = _appContext.entidades.FirstOrDefault(g => g.Correo == correo);
        
            if(entidadEncontrada != null)
                return true;
            else
                return false;
        }
        bool IRepositorioEntidad.SearchNITEntidad(string nit){
            var entidadEncontrada = _appContext.entidades.FirstOrDefault(g => g.NIT == nit);
        
            if(entidadEncontrada != null)
                return true;
            else
                return false;
        }
    }
}