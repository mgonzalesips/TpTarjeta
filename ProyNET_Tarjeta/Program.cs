// See https://aka.ms/new-console-template for more information
using System;
using Iteraciones;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("\n Test tarjeta queda con $300 de saldo negativo");
    Tarjeta tarjetaSN = new Tarjeta(640);
    Console.WriteLine(tarjetaSN.saldo);
    Colectivo bondi = new Colectivo();
    bondi.pagarCon(tarjetaSN);
    Console.WriteLine(tarjetaSN.saldo);
    tarjetaSN.cargarTarjeta(2000);
    Console.WriteLine(tarjetaSN.saldo); //deberia de dar 1700 = 2000-300

    Console.WriteLine("\n Test tarjeta no puede pagar");
    Tarjeta tarjetaSN1 = new Tarjeta(450);
    Console.WriteLine(tarjetaSN1.saldo);
    if(bondi.pagarCon(tarjetaSN1) == null)
      Console.WriteLine("No pudo pagar el boleto");
  
  }
}