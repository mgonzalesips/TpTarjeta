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
      tarjeta.CalcularFranquicia();
      Boleto boleto = new Boleto(tarjeta,this);
      int tarifa = boleto.GetTotalPagar();
      if (!tarjeta.EsPosibleViajar(tarifa)){
        return null;
      }
      else {
        tarjeta.Pagar(tarifa);
        tarjeta.CantUsosHoy = tarjeta.CantUsosHoy + 1;
        boleto.SaldoRestante = tarjeta.Saldo;
        tarjeta.AgregarBoleto(boleto);
        if (tarjeta.DeudaPaga > 0)
          {boleto.Descripcion = $"El boleto abonó {tarjeta.DeudaPaga} pesos de saldo negativo en la ultima carga";
          tarjeta.DeudaPaga = 0;}
        else 
          {boleto.Descripcion = null;}
      return boleto;}
    } 
  }
}