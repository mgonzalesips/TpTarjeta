using System;
using BoletoNamespace;
using ColectivoNamespace;
using TarjetaNamespace;

class Program {
  
  public static void Main (string[] args) {
    tarjeta tarjeta = new tarjeta();
    boleto boleto = new boleto();
    colectivo colectivo = new colectivo();
      
    Console.WriteLine ("Ingrese una opcion");
    Console.WriteLine ("1: Cargar saldo");
    Console.WriteLine ("2: Pagar boleto");
    
    string opcion = Console.ReadLine();
    while(true){
    switch (opcion) {
    case "1" :
        Console.WriteLine("Ingrese el monto a cargar");
        int monto = int.Parse(Console.ReadLine());
        tarjeta.cargarSaldo(monto);
        break;
    case "2":
        colectivo.PagarCon(tarjeta);
        break;
    default:
        Console.WriteLine("Opcion no valida");
        break;
        }}
  }
}
