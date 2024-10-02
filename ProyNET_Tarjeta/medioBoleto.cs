using System;
using System.Collections.Generic;

namespace Iteraciones
{
class MedioBoleto : Tarjeta
    {
        //Atributos
        public override float Descuento_franquicia => 0.5f;

        //Constructor 
        public MedioBoleto(int saldo) : base(saldo){
        }
    }
}