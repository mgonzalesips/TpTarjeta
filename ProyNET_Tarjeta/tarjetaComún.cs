using System;
using System.Collections.Generic;
using Iteraciones;
using System.Linq;


namespace Iteraciones
{
class TarjetaComun : Tarjeta
    {
        //Atributos
        private float desc;
        
        public override float Descuento_franquicia
    {
        get { return desc; }
        set { desc = value; }
    }

    
        //Constructor 
        public TarjetaComun(int saldo) : base(saldo){
            desc = 1.0f;
        }

        //Métodos
         public override bool EsPosibleViajar(int tarifa){
            if(saldo + 480 < tarifa)
                return false;
            else 
                return true;
         }
         public override void CalcularFranquicia(){
            desc = desc;
         }

    }
}