using System;

namespace TP{
  public class Boleto{
    private string Linea;
    private float Saldo;

    public Boleto(string linea, float saldo){
      Linea = linea;
      Saldo = saldo;
    }
  }
}