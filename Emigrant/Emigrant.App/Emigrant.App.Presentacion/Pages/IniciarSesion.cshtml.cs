using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Cryptography;
using Emigrant.App.Dominio;
using Emigrant.App.Persistencia;

namespace Emigrant.App.Presentacion.Pages
{
    public class IniciarSesionModel : PageModel
    {
        private static IRepositorioEntidad _repoEntidad = new RepositorioEntidad(new Emigrant.App.Persistencia.AppContext());
        private static IRepositorioMigrante _repoMigrante = new RepositorioMigrante(new Emigrant.App.Persistencia.AppContext());
        private static IRepositorioGerente _repoGerente = new RepositorioGerente(new Emigrant.App.Persistencia.AppContext());

        public Migrante migrante { get; set; }
        public Entidad entidad { get; set; }
        public Gerente gerente { get; set; }
        [BindProperty]
        public int status { get; set; } = 0;
        [BindProperty]
        public int sesion { get; set; } = 0;

        [BindProperty]
        public string message { get; set; } = "";
        public void OnGet()
        {
        }

        public void OnPostStartSession(string Correo, string Contrasena)
        {
            string ContrasenaE = ObtenerMd5(Contrasena);
            
            migrante = _repoMigrante.StartSession(Correo, ContrasenaE);
            if(migrante != null){ 
                if(migrante.estado == "habilitado"){
                    status = 1; 
                    sesion = 1;
                    message = "Inicio de sesion de " + migrante.Nombre;
                }
                else{
                    
                    status = 2; 
                    sesion = 0;
                    message = "Cuenta suspendida";
                }
            }
            else
            {
                entidad = _repoEntidad.StartSession(Correo, ContrasenaE);
                if(entidad != null){ 
                    if(entidad.estado == "habilitado" ){
                        status = 1; 
                        sesion = 2;
                        message = "Inicio de sesion de " + entidad.RazonSocial;
                    }else{
                        status = 2; 
                        sesion = 0;
                        message = "Cuenta suspendida";
                    }
                }
                else
                {
                    gerente = _repoGerente.StartSession(Correo, Contrasena);
                    if(gerente != null){ 
                        if(gerente.estado == "habilitado" ){
                            status = 1; 
                            sesion = 3;
                            message = "Inicio de sesion de " + gerente.Nombre;
                        }else{
                            status = 2; 
                            sesion = 0;
                            message = "Cuenta suspendida";
                        }
                    }
                    else
                    {
                        status = 2; 
                        sesion = 0;
                        message = "Inicio de sesion Incorrecto";
                    }
                }
                
            }
            
        }
        public string ObtenerMd5(string input)
        {
            MD5CryptoServiceProvider x = new MD5CryptoServiceProvider();
            byte[] bs = System.Text.Encoding.UTF8.GetBytes(input);
            bs = x.ComputeHash(bs);
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            foreach (byte b in bs)
            {
                s.Append(b.ToString("x2").ToLower());
            }
            string hash = s.ToString();
            return hash;
        }
    }
}