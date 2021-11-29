using System;

namespace Emigrant.App.Dominio
{
    public class Servicio
    {
      public int Id { get; set; }
      public string TipoNecesidad {get; set;}

      public string Detalle {get; set;}

      public string Clasificacion{ get; set;}

      public string Disponibilidad{ get; set;}

      public DateTime FechaInicio { get; set; }

      public DateTime FechaFinal { get; set; }
      
      public int Evaluacion { get; set; }

      public string Categoria { get; set; }
     
    }
}