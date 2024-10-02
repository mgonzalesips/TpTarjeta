// See https://aka.ms/new-console-template for more information
using System;
using Iteraciones;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Test franquicia completa \n");
    FranquiciaCompleta tarjeta1 = new FranquiciaCompleta(0);
    Console.WriteLine(tarjeta1.saldo);
    Colectivo bondi1 = new Colectivo();
    bondi1.pagarCon(tarjeta1);
    if (bondi1.pagarCon(tarjeta1) != null)
        Console.WriteLine("Boleto se creo exitosamente");
    Console.WriteLine(tarjeta1.saldo);

    Console.WriteLine("\nTest medio boleto \n");
    MedioBoleto tarjeta2 = new MedioBoleto(500);
    Console.WriteLine(tarjeta2.saldo);
    int saldo_previo = tarjeta2.saldo;
    Colectivo bondi2 = new Colectivo();
    bondi2.pagarCon(tarjeta2);
    Console.WriteLine(tarjeta2.saldo);
    Console.WriteLine(saldo_previo - tarjeta2.saldo); //da el valor del pasaje deberia ser 470 (940/2)
  }
}