using System;
using CalculadoraIMC.App.Dominio;

namespace CalculadoraIMC.App.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pedir datos
            string dato;
            float altura;
            float peso;
            Console.WriteLine("Ingrese su altura: ");
            //dato = Console.ReadLine();
            altura = float.Parse(Console.ReadLine());
             
            Console.WriteLine("Ingrese su peso: ");
            //dato = Console.ReadLine();
            peso = float.Parse(Console.ReadLine());

            //Crear clase IMC
            //IMC imc = new IMC(peso,altura);
            

            float IMC = (peso / (altura * altura));
            Console.WriteLine("        ");
            Console.WriteLine(peso);
            Console.WriteLine(altura);
            Console.WriteLine("        ");
            Console.WriteLine(IMC);
            Console.WriteLine("        ");
            String respuesta;

            if(IMC < 16)
                respuesta = "Delgadez Severa";
            else if(IMC >= 16 && IMC <= 16.99)
                respuesta = "Delgadez Moderada";
            else if(IMC >= 17 && IMC <= 18.49)
                respuesta = "Delgadez Aceptable";
            else if(IMC >= 18.5 && IMC <= 24.99)
                respuesta = "Peso Normal";
            else if(IMC >= 25 && IMC <= 29.99)
                respuesta = "Sobrepeso";
            else if(IMC >= 30 && IMC <= 34.99)
                respuesta = "Obesidad Tipo I";
            else if(IMC >= 35 && IMC <= 39.99)
                respuesta = "Obesidad Tipo II";
            else if(IMC >= 40 && IMC <= 49.99)
                respuesta = "Obesidad Tipo III o Morbidad";
            else if(IMC > 50)
                respuesta = "Obesidad Tipo IV o Extrema";
            else
                respuesta = "Error";

            //Utilizar metodo CalculadoraIMC
            Console.WriteLine(respuesta);
        }
    }
}
