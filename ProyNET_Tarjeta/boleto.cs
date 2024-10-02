using System;
using Iteraciones;

namespace Iteraciones
{
  class Boleto{
    //Atributos
    
      public static float tarifa_pasaje = 940.0f;
      public int saldo_restante;
      public Tarjeta tarjeta;
  
    //Constructores
      public Boleto(Tarjeta tarjeta){
        this.tarjeta = tarjeta;
      }
  }
}
