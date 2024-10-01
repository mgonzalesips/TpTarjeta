using System;

namespace TransporteUrbano
{
    public class Boleto
    {
        private string linea;
        private decimal costo;

        public Boleto(string linea, decimal costo)
        {
            this.linea = linea;
            this.costo = costo;
        }

        public override string ToString()
        {
            return $"Boleto para la línea {linea}, costo: {costo}";
        }
    }
}
