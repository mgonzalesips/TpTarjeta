using System;
using System.Collections.Generic;

namespace Iteraciones
{
  abstract class Tarjeta{
    //Atributos
    private static int id_contador = 0;
    public int Id {get; private set;}
    protected int saldo;
    public int Saldo {
        get { return saldo; }  
        set { saldo = value; }  
    }
    private int acreditación_pendiente;
    public int AcreditaciónPendiente {
        get { return acreditación_pendiente; }  
        set { acreditación_pendiente= value; }  
    }
    private int deuda_paga;
    public int DeudaPaga {
        get { return deuda_paga; }  
        set { deuda_paga = value; }  
    }
    public static int max_carga = 36000;
    public static List<int> posibles_cargas = new List<int> {2000, 3000, 4000, 5000, 6000, 7000, 8000, 9000};
    public abstract float Descuento_franquicia { get;set; }
    protected List<Boleto> boletos_pagos = new List<Boleto>();
    protected int cant_usos_hoy;
    public int CantUsosHoy {
        get { return cant_usos_hoy; }  
        set { cant_usos_hoy= value; }  
    }
    //Constructor

    public Tarjeta(int saldo){
      if(saldo <= max_carga)
        {this.saldo = saldo;}
      else 
        {this.saldo = max_carga;
        acreditación_pendiente = saldo - max_carga;}
      Id = ++id_contador;
    } 
    //Métodos
    public abstract bool EsPosibleViajar(int tarifa);
    public abstract void CalcularFranquicia();
    public bool cargarTarjeta(int carga){
      if (posibles_cargas.Contains(carga) && (saldo+carga) <= max_carga){
          if (saldo < 0){
            deuda_paga = saldo * (-1);
          }
            saldo += carga;
            return true;
          }
      else if ((saldo+carga) > max_carga){
            acreditación_pendiente = saldo + carga - max_carga;
            saldo = max_carga;
            return true;
          }
      else
          return false;
    }
    public void AgregarBoleto(Boleto boleto){
      if (boleto != null) 
        {boletos_pagos.Add(boleto);}
    }

    public void Pagar(int tarifa){
      if(tarifa < acreditación_pendiente){
        acreditación_pendiente -= tarifa;
      }
      else if (0 < acreditación_pendiente){
        acreditación_pendiente = 0;
        saldo = max_carga + acreditación_pendiente - tarifa;
      }
      else {
        saldo -= tarifa;
      }
    }
  }
}

