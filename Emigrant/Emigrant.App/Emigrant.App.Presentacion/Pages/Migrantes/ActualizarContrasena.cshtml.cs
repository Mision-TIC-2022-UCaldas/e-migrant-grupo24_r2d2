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
    public class ActualizarContrasenaModel : PageModel
    {
        private static IRepositorioMigrante _repoMigrante = new RepositorioMigrante(new Persistencia.AppContext());

        
        public Migrante migranteEncontrado { get; set; }

        public bool credencial{get; set;}

        [BindProperty]
        public int status { get; set; } = 0;

        [BindProperty]
        public string message { get; set; } =  "";
        

        public void OnGet(int Id)
        {
            migranteEncontrado = _repoMigrante.GetMigranteByID(Id); 
        }
        public void OnPostUpdateContrasena(Emigrant.App.Dominio.Migrante migrante, string ContrasenaAntigua)
        {
            Console.WriteLine(migrante.Id);
            Console.WriteLine(ContrasenaAntigua);

            ContrasenaAntigua = ObtenerMd5(ContrasenaAntigua);
            migrante.Contrasena = ObtenerMd5(migrante.Contrasena);

            credencial = _repoMigrante.UpdateCredencialesMigrante(migrante, ContrasenaAntigua);
            if (credencial)
            {
                status = 1;
                message = "Contraseña actualizada correctamente";
            }
            else{
                status = 2;
                message = "Fallo al actualizar contraseña";
                OnGet(migrante.Id);
                
            }
        }
        public string ObtenerMd5(string input)
        {
            MD5CryptoServiceProvider x = new MD5CryptoServiceProvider();
            byte[] bs = System.Text.Encoding.UTF8.GetBytes(input);
            bs = x.ComputeHash(bs);
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            foreach (byte b in bs)
            {
                s.Append(b.ToString("x2").ToLower());
            }
            string hash = s.ToString();
            return hash;
        }
    }
}
