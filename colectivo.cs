  using System;
  using TarjetaNamespace;
  using BoletoNamespace;

  namespace ColectivoNamespace
  {
      public class colectivo {
          boleto boleto;
          public void PagarCon (tarjeta tarjeta)
          {
              if (tarjeta.saldo >= boleto.precio)
              {
                  tarjeta.saldo -= boleto.precio;
                  Console.WriteLine("Pago realizado con éxito.");
              }
              else
              {
                  Console.WriteLine("Saldo insuficiente!");
              }
          }
      }
  }
