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
    public class AgregarAmigoModel : PageModel
    {
        private static IRepositorioAF _repoAF = new RepositorioAF(new Emigrant.App.Persistencia.AppContext());

        public AF amigo = new AF();
        public AF amigoAdd { get; set; }

        [BindProperty]
        public int status { get; set; } = 0;

        [BindProperty]
        public string message { get; set; } = "";

        public void OnGet(int IdPersona, int IdPropio)
        {
            amigo.IdPrimeraPersona = IdPropio;
            amigo.IdSegundaPersona = IdPersona;
            amigo.Tipo = "Amigo";

            amigoAdd = _repoAF.AddAmigo(amigo);

            if(amigoAdd != null){
                status = 1;
                message = amigoAdd.Tipo + " agregado";
            }
            else{
                status = 2;
                message = "Error al añadir el amigo";
            }        
        }
    }
}
