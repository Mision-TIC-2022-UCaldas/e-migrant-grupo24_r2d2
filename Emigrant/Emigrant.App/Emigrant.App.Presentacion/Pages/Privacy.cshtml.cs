using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Security.Cryptography;
using Emigrant.App.Dominio;
using Emigrant.App.Persistencia;

namespace Emigrant.App.Presentacion.Pages
{
    public class PrivacyModel : PageModel
    {
        private static IRepositorioMigrante _repoMigrante = new RepositorioMigrante(new Persistencia.AppContext());

        
        public Migrante migrante { get; set; }

        [BindProperty]
        public int status { get; set; } = 0;

        [BindProperty]
        public string message { get; set; } =  "";

        
        public void OnGet()
        {
            
        }

        public void OnPostSearch(string Documento)
        {
            migrante = _repoMigrante.GetMigranteByDocumento(Documento);
            if(migrante != null){
                status = 1;
                message = "Migrante Encontrado";
            }
            else{
                status = 2;
                message = "Usuario con Documento " + Documento + " No encontrado";
            }
            
        }


    }
}
