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
    public class ConsultarInformacionEModel : PageModel
    {
        private static IRepositorioEntidad _repoEntidad = new RepositorioEntidad(new Persistencia.AppContext());

        public Entidad entidad { get; set; }

        public void OnGet(int Id)
        {
            entidad = _repoEntidad.GetEntidadByID(Id);
            
        }
        
    }
}
