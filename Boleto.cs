using System;

namespace TpSube {
  public class Boleto {
      public string LineaColectivo { get; }
      public float SaldoRestante { get; }
      public float CostoDelPasaje { get; }
  
      public Boleto(Colectivo colectivo, float saldoRestante) {
          LineaColectivo = colectivo.Linea;
          SaldoRestante = saldoRestante;
          CostoDelPasaje = 940; 
      }
  
      // Método para mostrar la información del boleto
      public void MostrarBoleto() {
          Console.WriteLine($"Boleto de la línea: {LineaColectivo}");
          Console.WriteLine($"Costo del pasaje: ${CostoDelPasaje}");
          Console.WriteLine($"Saldo restante en la tarjeta: ${SaldoRestante}");
      }
  }
}