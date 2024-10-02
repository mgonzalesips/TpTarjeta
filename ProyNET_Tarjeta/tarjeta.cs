using System;
using System.Collections.Generic;

namespace Iteraciones
{
  class Tarjeta{
    //Atributos
    public int saldo;
    public static int max_carga = 9900;
    public static List<int> posibles_cargas = new List<int> {2000, 3000, 4000, 5000, 6000, 7000, 8000, 9000};
    //Constructor
  
    public Tarjeta(int saldo){
      this.saldo = saldo;
    } 
    //Métodos
  
    public bool cargarTarjeta(int carga){
      if (posibles_cargas.Contains(carga)){
        
        if ((saldo+carga) <= max_carga){
          saldo += carga;
          return true;
          }
        else
          return false;      
        }
      else 
        return false;
    }
  }
}

