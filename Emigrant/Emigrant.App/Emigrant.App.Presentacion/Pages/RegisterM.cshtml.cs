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
    public class RegisterMModel : PageModel
    {
        private static IRepositorioMigrante _repoMigrante = new RepositorioMigrante(new Emigrant.App.Persistencia.AppContext());

        [BindProperty]
        public int status { get; set; } = 0;

        [BindProperty]
        public string message { get; set; } =  "";

        public void OnGet()
        {
        }

        public void OnPostAdd(Emigrant.App.Dominio.Migrante migrante, string Fecha)
        {            
            if(_repoMigrante.SearchCorreoMigrante(migrante.Correo)){
                Console.WriteLine("Migrante no agregado");
                status = 2;
                    message = "Correo digitado ya existe";
            }
            else if(_repoMigrante.SearchDocumentoMigrante(migrante.Documento)){
                    status = 2;
                    message = "Documento ya existe";
            }
            else
            {
                string[] arrayFecha = Fecha.Split('/');

                migrante.FechaNacimiento = new DateTime(Convert.ToInt32(arrayFecha[2]), Convert.ToInt32(arrayFecha[0]), Convert.ToInt32(arrayFecha[1]), 0, 0, 0);
            
                migrante.estado = "habilitado";
                migrante.TipoCuenta = 2;
                migrante.Contrasena = ObtenerMd5(migrante.Contrasena);
			    _repoMigrante.AddMigrante(migrante); 
                status = 1;
                message = "Migrante agregado "+ migrante.Nombre;
                
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
