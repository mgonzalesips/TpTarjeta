using System;
using Iteraciones;

namespace Iteraciones
{
  class Colectivo{
    //Atributos
    //Métodos 
    
    public Boleto? pagarCon(Tarjeta tarjeta){
      Boleto boleto = new Boleto(tarjeta);
      if (tarjeta.saldo < Boleto.tarifa_pasaje){
        return null;
      }
      else {
        boleto.saldo_restante = tarjeta.saldo - Boleto.tarifa_pasaje;
        tarjeta.saldo -= Boleto.tarifa_pasaje;
      return boleto;}
    } 
  }
}