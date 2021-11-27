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
    public class RegisterEModel : PageModel
    {

        private static IRepositorioEntidad _repoEntidad = new RepositorioEntidad(new Emigrant.App.Persistencia.AppContext());

        public void OnPostAdd(Emigrant.App.Dominio.Entidad entidad)
        {
            entidad.Contrasena = ObtenerMd5(entidad.Contrasena);
			_repoEntidad.AddEntidad(entidad);     
            Console.WriteLine("Entidad agregado "+ entidad.RazonSocial);       
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
