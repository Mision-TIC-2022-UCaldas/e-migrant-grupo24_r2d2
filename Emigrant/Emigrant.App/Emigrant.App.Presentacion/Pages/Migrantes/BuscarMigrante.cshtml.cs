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
    public class BuscarMigranteModel : PageModel
    {
        private static IRepositorioMigrante _repoMigrante = new RepositorioMigrante(new Persistencia.AppContext());

        
        public Migrante migrante { get; set; }

        public Migrante migranteEncontrado { get; set; }

        [BindProperty]
        public int status { get; set; } = 0;

        [BindProperty]
        public string message { get; set; } =  "";

        [BindProperty]
        public int idGlobal { get; set; } = 0;

        
        public void OnGet(int Id)
        {
            //Sobreescribo el input del formulario invisible para poder enviarla con el boton
            idGlobal = Id;
        }

        public void OnPostSearch(string DocumentoB, int IdG)
        {            
            migrante = _repoMigrante.GetMigranteByDocumento(DocumentoB);

            if(migrante.Id == IdG){
                status = 2;
                message = "Ingrese otro documento";
            }else
            {
                if(migrante != null){
                    status = 1;
                    message = "Migrante Encontrado";
                }
                else{
                    status = 2;
                    message = "Usuario con Documento " + DocumentoB + " No encontrado";
                    Console.WriteLine("id"+migranteEncontrado.Id);
                    OnGet(migranteEncontrado.Id);
                }
            }
            
            
            idGlobal = IdG;
            Console.WriteLine(IdG);
            
        }
    }
}
