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
    public class ActualizarInformacionEModel : PageModel
    {
        private static IRepositorioEntidad _repoEntidad = new RepositorioEntidad(new Persistencia.AppContext());

        public Entidad entidadActualizado { get; set; }
        public Entidad entidadEncontrada { get; set; }

        [BindProperty]
        public int status { get; set; } = 0;

        [BindProperty]
        public string message { get; set; } =  "";
        

        public void OnGet(int Id)
        {
            
            entidadEncontrada = _repoEntidad.GetEntidadByID(Id); 
        }
        public void OnPostUpdate(Emigrant.App.Dominio.Entidad entidad)
        {
            Console.WriteLine("Por aqui paso");
            entidadActualizado = _repoEntidad.UpdateEntidad(entidad);
            if (entidadActualizado != null)
            {
                status = 1;
                message = "Informacion actualizada";
                OnGet(entidad.Id);
            }
            else{
                status = 2;
                message = "Error actualizando";
            }
        }
    }
}
