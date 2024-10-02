using System;
using Iteraciones;

namespace Iteraciones
{
  class Colectivo{
    //Atributos

    //Métodos 
    
    public Boleto? pagarCon(Tarjeta tarjeta){
      Boleto boleto = new Boleto(tarjeta);
      if (tarjeta.saldo +480 < ((int)(Boleto.tarifa_pasaje * tarjeta.Descuento_franquicia))){
        return null;
      }
      else {
        boleto.saldo_restante = tarjeta.saldo - ((int)(Boleto.tarifa_pasaje * tarjeta.Descuento_franquicia));
        tarjeta.saldo -= ((int)(Boleto.tarifa_pasaje * tarjeta.Descuento_franquicia));
      return boleto;}
    } 
  }
}