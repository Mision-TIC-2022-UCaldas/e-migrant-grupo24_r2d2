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
    public class SuspenderCuentaModel : PageModel
    {
        private static IRepositorioAdmin _repoAdmin = new RepositorioAdmin(new Persistencia.AppContext());

        public Admin admin { get; set; }
        public Migrante migrante { get; set; }
        public Entidad entidad { get; set; }
        public Gerente gerente { get; set; }
        [BindProperty]
        public int status { get; set; } = 0;

        [BindProperty]
        public string message { get; set; } = "";
        public void OnGet(int Id, int Type)
        {
            if(Type == 1)
            { 
                entidad = _repoAdmin.CancelarCuentaEntidad(Id);
                if(entidad!=null){
                    status = 2;
                    message = "La cuenta de " + entidad.RazonSocial + " Fue suspendida";
                }
                else{
                    status = 2;
                    message = "La cuenta no existe o no pudo ser suspendida";
                }
                
            }
            else if(Type == 2)
            {
                migrante = _repoAdmin.CancelarCuentaMigrante(Id);
                if(migrante!=null){
                    status = 2;
                    message = "La cuenta de " + migrante.Nombre + " Fue suspendida";
                }
                else{
                    status = 2;
                    message = "La cuenta no existe o no pudo ser suspendida";
                }
            }else if(Type == 3)
            {
                gerente = _repoAdmin.CancelarCuentaGerente(Id);
                if(gerente!=null){
                    status = 2;
                    message = "La cuenta de " + gerente.Nombre + " Fue suspendida";
                }
                else{
                    status = 2;
                    message = "La cuenta no existe o no pudo ser suspendida";
                }
            }
            else{
                status = 2;
                message = "Sin funcion";
            }
                
        }
        
    }
}
