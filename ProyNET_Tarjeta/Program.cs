// See https://aka.ms/new-console-template for more information
using System;
using Iteraciones;

class Program {
  public static void Main (string[] args) {
    Tarjeta tarjeta = new Tarjeta(1000);
    Console.WriteLine(tarjeta.saldo);
    Colectivo bondi = new Colectivo();
    bondi.pagarCon(tarjeta);
    Console.WriteLine(tarjeta.saldo);
    
  }
}