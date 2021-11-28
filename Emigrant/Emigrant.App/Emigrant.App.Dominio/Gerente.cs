using System;

namespace Emigrant.App.Dominio
{
    public class Gerente
    {
      public int Id { get; set; }

      public string Nombre {get; set;}
      public string Apellido {get; set;}
      public string Correo {get; set;}

      public string Contrasena { get; set;}
      public int TipoCuenta { get; set;}
      public string estado { get; set; }
     
    }
}