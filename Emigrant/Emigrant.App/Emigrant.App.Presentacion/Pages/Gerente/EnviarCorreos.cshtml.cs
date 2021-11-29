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
    public class EnviarCorreosModel : PageModel
    {
        private static IRepositorioMigrante _repoMigrante = new RepositorioMigrante(new Persistencia.AppContext());
        
        public IEnumerable<Migrante> migrantes { get; private set;}

        private static IRepositorioEntidad _repoEntidad = new RepositorioEntidad(new Persistencia.AppContext());
        
        public IEnumerable<Entidad> entidades { get; private set;}

        private static IRepositorioGerente _repoGerente = new RepositorioGerente(new Persistencia.AppContext());
        
        public IEnumerable<Gerente> gerentes { get; private set;}

        
        public void OnGet()
        {
            migrantes = _repoMigrante.GetAllMigrantes();
            entidades = _repoEntidad.GetAllEntidades();
            gerentes = _repoGerente.GetAllGerentes();
        }
    }
}
