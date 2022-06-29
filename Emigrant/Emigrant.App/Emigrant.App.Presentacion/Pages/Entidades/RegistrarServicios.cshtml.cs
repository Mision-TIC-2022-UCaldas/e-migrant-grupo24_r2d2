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
    public class RegistrarServiciosModel : PageModel
    {
        private static IRepositorioServicios _repoServicio = new RepositorioServicios(new Emigrant.App.Persistencia.AppContext());

        [BindProperty]
        public int status { get; set; } = 0;

        [BindProperty]
        public string message { get; set; } =  "";

        public void OnGet()
        {
        }

        public void OnPostAdd(Emigrant.App.Dominio.Servicio servicio, string FechaI, string FechaF)
        {            
            string[] arrayFechaI = FechaI.Split('/');
            string[] arrayFechaF = FechaF.Split('/');

            servicio.FechaInicio = new DateTime(Convert.ToInt32(arrayFechaI[2]), Convert.ToInt32(arrayFechaI[0]), Convert.ToInt32(arrayFechaI[1]), 0, 0, 0);
            servicio.FechaFinal = new DateTime(Convert.ToInt32(arrayFechaF[2]), Convert.ToInt32(arrayFechaF[0]), Convert.ToInt32(arrayFechaF[1]), 0, 0, 0);       
            servicio.Disponibilidad = "Disponible";
            
            _repoServicio.AddServicio(servicio); 
            status = 1;
            message = "Servicio "+ servicio.Categoria + " agregado";
            
        
        }
    }
}
