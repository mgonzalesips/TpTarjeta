using System;
using Iteraciones;

namespace Iteraciones
{
  class Boleto{
    //Atributos
    
      public static int tarifa_pasaje = 940;
      public int saldo_restante;
      public Tarjeta tarjeta;
  
    //Constructores
      public Boleto(Tarjeta tarjeta){
        this.tarjeta = tarjeta;
      }
  }
}
