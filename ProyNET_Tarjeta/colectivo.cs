using System;
using Iteraciones;

namespace Iteraciones
{
  class Colectivo{
    //Atributos
    private string linea;
    public string Linea {get {return linea;}}
    //Constructor
    public Colectivo(string linea = "interurbano"){
        this.linea = linea;
    }
    //Métodos 
    
    public Boleto? pagarCon(Tarjeta tarjeta){
      Boleto boleto = new Boleto(tarjeta,this);
      int tarifa = boleto.GetTotalPagar();
      if (tarjeta.Saldo +480 < tarifa){
        return null;
      }
      else {
        tarjeta.Pagar(tarifa);
        boleto.SaldoRestante = tarjeta.Saldo;
        if (tarjeta.DeudaPaga > 0)
          {boleto.Descripcion = $"El boleto abonó {tarjeta.DeudaPaga} pesos de saldo negativo en la ultima carga";
          tarjeta.DeudaPaga = 0;}
        else 
          {boleto.Descripcion = null;}
      return boleto;}
    } 
  }
}