using System;
using System.Collections.Generic;

namespace TpSube {
  public class Colectivo {
      public string Linea { get; }

      // Lista para almacenar las lineas del programa
      private static List<string> lineasRegistradas = new List<string>();

      //Metodo para registrar la linea de colectivo
      public Colectivo(string linea) {
          Linea = linea;
          lineasRegistradas.Add(linea);
      }

      // Método para pagar con la tarjeta
      public Boleto PagarCon(Tarjeta tarjeta) {
          if (tarjeta.PagarPasaje()) {
              return new Boleto(this, tarjeta.saldo);
          }
          return null; // No se pudo pagar, saldo insuficiente
      }
  }
}