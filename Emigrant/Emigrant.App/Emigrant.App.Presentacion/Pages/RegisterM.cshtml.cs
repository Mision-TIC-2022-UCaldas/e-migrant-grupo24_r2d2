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
        private static IRepositorioMigrante_ _repoMigrante = new RepositorioMigrante_(new Emigrant.App.Persistencia.AppContext());

        public void OnGet()
        {
        }

        public void OnPostAdd(Emigrant.App.Dominio.Migrante_ migrante)
        {
            migrante.Contrasena = ObtenerMd5(migrante.Contrasena);
			_repoMigrante.AddMigrante(migrante);     
            Console.WriteLine("Migrante agregado "+ migrante.Nombre);       
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
