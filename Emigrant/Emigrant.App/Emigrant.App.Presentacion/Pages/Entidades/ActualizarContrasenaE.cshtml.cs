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
    public class ActualizarContrasenaEModel : PageModel
    {
        private static IRepositorioEntidad _repoEntidad = new RepositorioEntidad(new Persistencia.AppContext());

        
        public Entidad entidadEncontrada { get; set; }

        public bool credencial{get; set;}

        [BindProperty]
        public int status { get; set; } = 0;

        [BindProperty]
        public string message { get; set; } =  "";
        

        public void OnGet(int Id)
        {
            entidadEncontrada = _repoEntidad.GetEntidadByID(Id); 
        }
        public void OnPostUpdateContrasena(Emigrant.App.Dominio.Entidad entidad, string ContrasenaAntigua)
        {
            Console.WriteLine(entidad.Id);
            Console.WriteLine(ContrasenaAntigua);

            ContrasenaAntigua = ObtenerMd5(ContrasenaAntigua);
            entidad.Contrasena = ObtenerMd5(entidad.Contrasena);

            credencial = _repoEntidad.UpdateCredencialesEntidad(entidad, ContrasenaAntigua);
            if (credencial)
            {
                status = 1;
                message = "Contraseña actualizada correctamente";
            }
            else{
                status = 2;
                message = "Fallo al actualizar contraseña";
                OnGet(entidad.Id);
                
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
