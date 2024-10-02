using System;
using System.Collections.Generic;

namespace Iteraciones
{
class FranquiciaCompleta : Tarjeta
    {
        //Atributos
        public override float Descuento_franquicia => 0.0f;
        //Constructor 
        public FranquiciaCompleta(int saldo) : base(saldo){
        }
    }
}