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
            var entidadEncontrada = _appContext.entidades.FirstOrDefault(g => g.Correo == Correo && g.Contrasena == Contrasena );
            
            return entidadEncontrada;
            
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

        bool IRepositorioEntidad.UpdateCredencialesEntidad(Entidad entidad, string ContrasenaA)
        {

            var EntidadEncontrada = _appContext.entidades.FirstOrDefault(g => g.Id == entidad.Id);

            if (EntidadEncontrada != null)
            {
                
                if (EntidadEncontrada.Contrasena.Equals(ContrasenaA))
                {
                    EntidadEncontrada.Contrasena = entidad.Contrasena;
                    _appContext.SaveChanges();
                    return true;
                }
                else
                    return false;
                
            }
            else
                return false;
            
        }

        Entidad IRepositorioEntidad.UpdateEntidad(Entidad entidad)
        {
            var EntidadEncontrada = _appContext.entidades.FirstOrDefault(g => g.Id == entidad.Id);

            if (EntidadEncontrada != null)
            {
                EntidadEncontrada.RazonSocial = entidad.RazonSocial;
                EntidadEncontrada.Direccion = entidad.Direccion;
                EntidadEncontrada.Ciudad = entidad.Ciudad;
                EntidadEncontrada.Telefono = entidad.Telefono;
                EntidadEncontrada.PaginaWeb = entidad.PaginaWeb;
                EntidadEncontrada.TipoServicios = entidad.TipoServicios;
                EntidadEncontrada.Sector = entidad.Sector;
                
                _appContext.SaveChanges();
            }

            return EntidadEncontrada;

        }

        Entidad IRepositorioEntidad.GetEntidadByID(int idEntidad){
            var entidadEncontrada = _appContext.entidades.FirstOrDefault(g => g.Id == idEntidad);            
            return entidadEncontrada;
        }
        
    }
}