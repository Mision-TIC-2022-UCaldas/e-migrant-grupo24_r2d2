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

    public class AdminModel : PageModel
    {
        private static IRepositorioAdmin _repoAdmin = new RepositorioAdmin(new Emigrant.App.Persistencia.AppContext());

        public Admin admin { get; set; }
        public Admin adminModel { get; set; }

        


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
            admin = _repoAdmin.StartSession(Correo, Contrasena);
            if(admin != null){ 
                status = 2; 
                sesion = 1;
                message = "Bienvenido ADMIN ";
            }
            else
            {
                status = 2; 
                sesion = 2;
                message = "Fallo al entrar";
            }
        }

    
    }
}
