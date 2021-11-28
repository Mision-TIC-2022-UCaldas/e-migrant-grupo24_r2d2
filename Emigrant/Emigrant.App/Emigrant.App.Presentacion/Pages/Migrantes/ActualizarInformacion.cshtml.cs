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
    public class ActualizarInformacionModel : PageModel
    {
        private static IRepositorioMigrante _repoMigrante = new RepositorioMigrante(new Persistencia.AppContext());

        public Migrante migranteActualizado { get; set; }
        public Migrante migranteEncontrado { get; set; }

        [BindProperty]
        public int status { get; set; } = 0;

        [BindProperty]
        public string message { get; set; } =  "";
        

        public void OnGet(int Id)
        {
            
            migranteEncontrado = _repoMigrante.GetMigranteByID(Id); 
        }
        public void OnPostUpdate(Emigrant.App.Dominio.Migrante migrante)
        {
        
            migranteActualizado = _repoMigrante.UpdateMigrante(migrante);
            if (migranteActualizado != null)
            {
                status = 1;
                message = "Informacion actualizada";
                OnGet(migrante.Id);
            }
            else{
                status = 2;
                message = "Error actualizando";
            }
        }
    }
}
