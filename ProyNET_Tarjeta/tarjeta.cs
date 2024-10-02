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
    private int deuda_paga;
    public int DeudaPaga {
        get { return deuda_paga; }  
        set { deuda_paga = value; }  
    }
    public static int max_carga = 9900;
    public static List<int> posibles_cargas = new List<int> {2000, 3000, 4000, 5000, 6000, 7000, 8000, 9000};
    public abstract float Descuento_franquicia {get;}
    private List<Boleto> boletos_pagos = new List<Boleto>();

    //Constructor

    public Tarjeta(int saldo){
      this.saldo = saldo;
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
        else
          return false;
    }
    public List<Boleto> GetBoletos()
    {
      return new List<Boleto>(boletos_pagos);
    }
  }
}

