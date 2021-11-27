using System;
using Microsoft.EntityFrameworkCore;
using Emigrant.App.Dominio;

namespace Emigrant.App.Persistencia
 {


    public class AppContext: DbContext
    {
        public DbSet<Migrante_> migrantes {get;set;}
        public DbSet<Entidad> entidades {get;set;}
    


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           if(!optionsBuilder.IsConfigured) 
           {
               optionsBuilder.UseSqlServer("Data Source= (localdb)\\MSSQLLocalDB;Initial Catalog=Grupo24_R2D2_P1");
           }
        }
    }
}