using System;
using Iteracion1;

namespace Iteracion1
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
