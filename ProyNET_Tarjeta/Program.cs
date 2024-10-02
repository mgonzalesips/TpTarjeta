// See https://aka.ms/new-console-template for more information
using System;
using Iteraciones;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("\n Test tarjeta queda con $300 de saldo negativo");
    TarjetaComun tarjetaSN = new TarjetaComun(640);
    Console.WriteLine(tarjetaSN.saldo);
    Colectivo bondi = new Colectivo();
    bondi.pagarCon(tarjetaSN);
    Console.WriteLine(tarjetaSN.saldo);
    tarjetaSN.cargarTarjeta(2000);
    Console.WriteLine(tarjetaSN.saldo); //deberia de dar 1700 = 2000-300

    Console.WriteLine("\n Test tarjeta no puede pagar");
    TarjetaComun tarjetaSN1 = new TarjetaComun(450);
    Console.WriteLine(tarjetaSN1.saldo);
    if(bondi.pagarCon(tarjetaSN1) == null)
      Console.WriteLine("No pudo pagar el boleto");
  
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