using System;
using System.Collections.Generic;
using System.Linq;

namespace Iteraciones
{
class MedioBoleto : Tarjeta
    {
        //Atributos
        private float desc;
        
        public override float Descuento_franquicia
    {
        get { return desc; }
        set { desc = value; }
    }

        //Constructor 
        public MedioBoleto(int saldo) : base(saldo){
            desc = 0.5f;
        }
        //Métodos
        public override bool EsPosibleViajar(int tarifa){
            if(saldo + 480 < tarifa)
                {return false;}
            Boleto ult_bol = boletos_pagos.LastOrDefault();
            if(ult_bol != null){
                TimeSpan dif = DateTime.Now - ult_bol.GetFecha();
                if(dif.TotalMinutes < 5)
                    {return false;}
                else
                    {return true;}
                }
            else 
                return true;
            }  
        public override void CalcularFranquicia(){
            if (cant_usos_hoy < 4)
                Descuento_franquicia = 0.5f;
            else 
                Descuento_franquicia = 1.0f;  

            }
    }
}