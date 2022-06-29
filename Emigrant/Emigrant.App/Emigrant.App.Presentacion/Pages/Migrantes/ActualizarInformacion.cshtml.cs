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
        public void OnPostUpdate(Emigrant.App.Dominio.Migrante migrante, string Fecha)
        {

            string[] arrayFecha = Fecha.Split('/');
            migrante.FechaNacimiento = new DateTime(Convert.ToInt32(arrayFecha[2]), Convert.ToInt32(arrayFecha[0]), Convert.ToInt32(arrayFecha[1]), 0, 0, 0);
            
            DateTime date2 = new DateTime(2021, 11, 28, 12, 0, 0);
            DateTime date1 = new DateTime(1850, 11, 28, 12, 0, 0);


            int result = DateTime.Compare(migrante.FechaNacimiento, date2);
            int result2 = DateTime.Compare(date1, migrante.FechaNacimiento);

            if(result < 0 && result2 < 0){
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
            else{
                status = 2;
                message = "Fecha Incorrecta";
            }
            
        }
    }
}
