using System;

namespace Emigrant.App.Dominio
{
    public class Migrante
    {
      public int Id { get; set; }
      public string Nombre { get; set; }
      public string Apellido { get; set; } 
      public string Correo { get; set; }
      public string Contrasena { get; set; }
      public string TipoDoc { get; set; }
      public string Documento { get; set; }
      public DateTime FechaNacimiento { get; set; }
      public string Ciudad { get; set; }
      public string PaisOrigen { get; set; }
      public string SituacionLaboral { get; set; }
      public string Telefono { get; set; }
      public string Direccion { get; set; }
      public string estado { get; set; }
      public int TipoCuenta{ get; set;}
        
    }
}