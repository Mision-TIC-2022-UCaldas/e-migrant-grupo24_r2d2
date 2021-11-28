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

        public Migrante migrante { get; set; }
        public Entidad entidad { get; set; }
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
            Contrasena = ObtenerMd5(Contrasena);
            migrante = _repoMigrante.StartSession(Correo, Contrasena);
            if(migrante != null){ 
                status = 2; 
                sesion = 1;
                message = "Inicio de sesion de " + migrante.Nombre;
            }
            else
            {
                entidad = _repoEntidad.StartSession(Correo, Contrasena);
                if(entidad != null){ 
                    status = 2; 
                    sesion = 2;
                    message = "Inicio de sesion de " + entidad.RazonSocial;
                }
                else
                {
                    status = 2; 
                    sesion = 0;
                    message = "Inicio de sesion Incorrecto";
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