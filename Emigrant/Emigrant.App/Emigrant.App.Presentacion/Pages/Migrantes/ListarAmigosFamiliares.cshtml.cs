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
    public class ListarAmigosFamiliaresModel : PageModel
    {
        private static IRepositorioAF _repoAF = new RepositorioAF(new Emigrant.App.Persistencia.AppContext());
        private static IRepositorioMigrante _repoMigrante = new RepositorioMigrante(new Emigrant.App.Persistencia.AppContext());

        public Migrante migrante { get; set; }

        public IEnumerable<AF> af { get; private set;}

        public void OnGet(int Id)
        {
            //af = _repoAF.GetAFbyId(Id);
            //migrante = _repoMigrante.GetMigranteByDocumento(DocumentoB);
        }
    }
}
