using System;
using Iteraciones;

namespace Iteraciones
{
  class Boleto{
    //Atributos
    
      public static float tarifa_pasaje = 940.0f;
      private int saldo_restante;
      public int SaldoRestante  {
        get {return saldo_restante;}
        set {saldo_restante = value;}
      }
      private Tarjeta tarjeta;
      private string tipoTarjeta;
      private string linea_viajada;
      private int total_a_pagar;
      private DateTime fecha;
      private string? descripcion_saldo_neg;
      public string? Descripcion {
        get {return descripcion_saldo_neg;}
        set {descripcion_saldo_neg = value;}
      }
    //Constructores
      public Boleto(Tarjeta tarjeta, Colectivo colectivo){
        this.tarjeta = tarjeta;
        fecha = DateTime.Now;
        tipoTarjeta = tarjeta.GetType().Name;
        total_a_pagar = ((int)(Boleto.tarifa_pasaje * tarjeta.Descuento_franquicia));
        linea_viajada = colectivo.Linea;
      }

    //Métodos 
      public DateTime GetFecha(){
        return fecha;
      }
      public string GetTipoTarjeta(){
        return tipoTarjeta;
      }
      public string GetLineaColectivo(){
        return linea_viajada;
      }
      public int GetTotalPagar(){
        return total_a_pagar;
      }
      public int GetSaldo(){
        return tarjeta.Saldo;
      }
      public int GetIdTarjeta(){
        return tarjeta.Id;
      }
  }
}
