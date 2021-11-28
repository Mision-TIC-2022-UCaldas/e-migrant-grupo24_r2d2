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
            
            return MigranteEncontrado;
            
        }

        Migrante IRepositorioMigrante.GetMigranteByID(int idMigrante){
            var migranteEncontrado = _appContext.migrantes.FirstOrDefault(g => g.Id == idMigrante);            
            return migranteEncontrado;
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

        bool IRepositorioMigrante.UpdateCredencialesMigrante(Migrante migrante, string ContrasenaA)
        {

            var MigranteEncontrado = _appContext.migrantes.FirstOrDefault(g => g.Id == migrante.Id);

            if (MigranteEncontrado != null)
            {
                
                if (MigranteEncontrado.Contrasena.Equals(ContrasenaA))
                {
                    MigranteEncontrado.Contrasena = migrante.Contrasena;
                    _appContext.SaveChanges();
                    return true;
                }
                else
                    return false;
                
            }
            else
                return false;

            
        }

        Migrante IRepositorioMigrante.UpdateMigrante(Migrante migrante)
        {
            var MigranteEncontrado = _appContext.migrantes.FirstOrDefault(g => g.Id == migrante.Id);

            if (MigranteEncontrado != null)
            {
                MigranteEncontrado.Nombre = migrante.Nombre;
                MigranteEncontrado.Apellido = migrante.Apellido;
                MigranteEncontrado.TipoDoc = migrante.TipoDoc;
                MigranteEncontrado.Documento = migrante.Documento;
                MigranteEncontrado.FechaNacimiento = migrante.FechaNacimiento;
                MigranteEncontrado.Ciudad = migrante.Ciudad;
                MigranteEncontrado.PaisOrigen = migrante.PaisOrigen;
                MigranteEncontrado.SituacionLaboral = migrante.SituacionLaboral;
                MigranteEncontrado.Telefono = migrante.Telefono;
                MigranteEncontrado.Direccion = migrante.Direccion;

                _appContext.SaveChanges();
            }

            return MigranteEncontrado;

        }
    }
}