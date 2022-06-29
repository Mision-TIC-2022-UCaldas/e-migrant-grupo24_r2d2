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

        [BindProperty]
        public int status { get; set; } = 0;

        [BindProperty]
        public string message { get; set; } =  "";
        
        public void OnPostAdd(Emigrant.App.Dominio.Entidad entidad)
        {
            if(_repoEntidad.SearchCorreoEntidad(entidad.Correo)){
                Console.WriteLine("Entidad no agregada");
                status = 2;
                message = "Correo digitado ya existe";
            }
            else if(_repoEntidad.SearchNITEntidad(entidad.NIT)){
                    status = 2;
                    message = "NIT ya esta registrado";
            }
            else
            {
                entidad.estado = "habilitado";
                entidad.TipoCuenta = 1;
                entidad.Contrasena = ObtenerMd5(entidad.Contrasena);
                _repoEntidad.AddEntidad(entidad);     
                Console.WriteLine("Entidad agregada "+ entidad.RazonSocial); 
                status = 1;
                message = "Entidad agregada";
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
