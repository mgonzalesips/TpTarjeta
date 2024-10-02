using System;
using System.Collections.Generic;

namespace Iteraciones
{
class TarjetaComun : Tarjeta
    {
        //Atributos
        public override float Descuento_franquicia => 1.0f;
    
        //Constructor 
        public TarjetaComun(int saldo) : base(saldo){
        }
    }
}