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
    public class ConsultarInformacionModel : PageModel
    {
        private static IRepositorioMigrante _repoMigrante = new RepositorioMigrante(new Persistencia.AppContext());

        public Migrante migrante { get; set; }

        //[BindProperty]
        //public bool estado { get; set; } = false;

        [BindProperty]
        public int status { get; set; } = 0;
        public void OnGet(int Id)
        {
            migrante = _repoMigrante.GetMigranteByID(Id);
            
        }
        
    }
}
