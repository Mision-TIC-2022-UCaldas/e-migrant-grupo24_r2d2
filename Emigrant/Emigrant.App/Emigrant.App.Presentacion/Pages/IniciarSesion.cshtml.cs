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
        private static IRepositorioMigrante_ _repoMigrante = new RepositorioMigrante_(new Emigrant.App.Persistencia.AppContext());

        [BindProperty]
        public int status { get; set; } = 0;

        [BindProperty]
        public string message { get; set; } = "";
        public void OnGet()
        {
        }

        /*public IActionResult OnPostStartSession(string usuario, string clave)
        {

            
        }*/
    }
}