using System;
using System.Collections.Generic;

namespace Iteraciones
{
  abstract class Tarjeta{
    //Atributos
    private static int id_contador = 0;
    public int Id {get; private set;}
    private int saldo;
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
    public abstract float Descuento_franquicia {get;}
    private List<Boleto> boletos_pagos = new List<Boleto>();

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
    public List<Boleto> GetBoletos()
    {
      return new List<Boleto>(boletos_pagos);
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

