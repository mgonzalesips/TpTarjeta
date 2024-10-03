using System;
using System.Collections.Generic;

namespace Iteraciones
{
class FranquiciaCompleta : Tarjeta
    {
        //Atributos
        private float desc;
        
        public override float Descuento_franquicia
    {
        get { return desc; }
        set { desc = value; }
    }
        //Constructor 
        public FranquiciaCompleta(int saldo) : base(saldo){
            desc = 0.0f;
        }
        //Métodos
         public override bool EsPosibleViajar(int tarifa){
            if(saldo + 480 < tarifa)
                return false;
            else 
                return true;
         }
         public override void CalcularFranquicia(){
            if (cant_usos_hoy < 2)
                Descuento_franquicia = 0.0f;
            else 
                Descuento_franquicia = 1.0f;  
         }
    }
}