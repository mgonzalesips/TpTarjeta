using System;

namespace TP{
  public class Colectivo{
    public string Linea;
    private float precio = 940;

    public Colectivo(string linea){
      this.Linea = linea;
    }
    
    public Boleto Pasaje(Tarjeta tarjeta){
      
      if(tarjeta.VerSaldo() >= precio){ 
        tarjeta.RestarSaldo(precio);
        return new Boleto(Linea, tarjeta.VerSaldo());
      }
      else{
        Console.WriteLine("No tiene saldo suficiente");
           return null; 
      }  
    }
  }
}