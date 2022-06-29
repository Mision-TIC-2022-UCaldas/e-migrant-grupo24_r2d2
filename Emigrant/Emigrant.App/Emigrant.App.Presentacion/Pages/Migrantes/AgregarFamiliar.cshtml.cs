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
    public class AgregarFamiliarModel : PageModel
    {
        private static IRepositorioAF _repoAF = new RepositorioAF(new Emigrant.App.Persistencia.AppContext());

        public AF familiar = new AF();
        public AF familiarAdd { get; set; }

        [BindProperty]
        public int status { get; set; } = 0;

        [BindProperty]
        public string message { get; set; } = "";

        public void OnGet(int IdPersona, int IdPropio)
        {
            familiar.IdPrimeraPersona = IdPropio;
            familiar.IdSegundaPersona = IdPersona;
            familiar.Tipo = "Familiar";

            familiarAdd = _repoAF.AddFamiliar(familiar);

            if(familiarAdd != null){
                status = 1;
                message = familiarAdd.Tipo + " agregado";
            }
            else{
                status = 2;
                message = "Error al añadir el familiar";
            }        
        }
        
    }
}
