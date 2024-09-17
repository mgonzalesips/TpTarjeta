using System;
using Iteracion1;

namespace Iteracion1
{
  class Colectivo{
    //Atributos
    Tarjeta tarjeta;
    //Métodos 
    
    public Boleto pagarCon(Tarjeta tarjeta){
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