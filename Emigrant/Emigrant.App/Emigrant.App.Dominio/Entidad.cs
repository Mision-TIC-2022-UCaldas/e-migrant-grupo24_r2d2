using System;

namespace Emigrant.App.Dominio
{
    public class Entidad
    {
      public int Id { get; set; }
      public string RazonSocial { get; set; }
      public string NIT { get; set; } 
      public string Correo { get; set; }
      public string Contrasena { get; set; }
      public string Direccion { get; set; }
      public string Ciudad { get; set; }
      public string Telefono { get; set; }
      public string Sector { get; set; }
      public string TipoServicios { get; set; }
      public string PaginaWeb { get; set; }
    }
}