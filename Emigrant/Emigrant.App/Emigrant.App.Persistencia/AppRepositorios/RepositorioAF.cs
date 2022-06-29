using System;
using Emigrant.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Emigrant.App.Persistencia
{
    public class RepositorioAF : IRepositorioAF
    {
        private readonly AppContext _appContext;

        public RepositorioAF(AppContext appContext)
        {
            _appContext = appContext;
        }

        AF IRepositorioAF.AddAmigo(AF af)
        {
            var amigoAdicionado = _appContext.amigoFam.Add(af);
            _appContext.SaveChanges();
            return amigoAdicionado.Entity;
        }

        AF IRepositorioAF.AddFamiliar(AF af)
        {
            var familiarAdicionado = _appContext.amigoFam.Add(af);
            _appContext.SaveChanges();
            return familiarAdicionado.Entity;
        }


        // IEnumerable<AF> IRepositorioAF.GetAFbyId(int id){
             
        //     var queryIdByAF =
        //     from cust in amigoFam
        //     group Tipo by Tipo.;

                  
        //     var af = (from p in _appContext.amigoFam where p.Tipo == "Amigo" select p).First();
               
        //     return af;
        // }
        
    }
}