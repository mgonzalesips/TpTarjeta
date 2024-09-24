using System;

namespace TP{
  public class Boleto{
    private string Linea;
    private float Saldo;

    public Boleto(string linea, float saldo){
      this.Linea = linea;
      this.Saldo = saldo;
    }
  }
}