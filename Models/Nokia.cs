using System;
namespace main.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
       
      public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria){
        
      }

       // TODO: Sobrescrever o método "InstalarAplicativo"
      public override void InstalarAplicativo(string nomeApp){
        Console.WriteLine("Instalando o app {0} no Nokia Nº {1}", nomeApp, Numero);
      }
      
    }
}