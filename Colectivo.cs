using System;
namespace Space
{
    public class Colectivo
    {
        public int tarifa = 940;
        public string linea;
        public Colectivo(string linea1)
        {
            this.linea = linea1;
        }

        public bool Descontar(Tarjeta tarjeta)
        {
            if (tarjeta.saldo - tarifa >= 0)
            {
                tarjeta.saldo -= tarifa;
                return true;
            }
            else
            {
                Console.WriteLine("No se pudo pagar. Saldo insuficiente.");
                return false;
            }
        }

        public Boleto PagarCon(Tarjeta tarjeta)
        {
            if (Descontar(tarjeta))
            {
                tarjeta.historial[tarjeta.historial.Length] = new Boleto(tarifa, linea, tarjeta.saldo);
                return new Boleto(tarifa, linea, tarjeta.saldo);
            }
            else
            {
                Console.WriteLine("No se pudo emitir el boleto.");
                return null;
            }
        }
    }
}