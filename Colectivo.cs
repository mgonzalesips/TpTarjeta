using System;

namespace TransporteUrbano
{
    public class Colectivo
    {
        private string linea;
        private const decimal Tarifa = 940m;

        public Colectivo(string linea)
        {
            this.linea = linea;
        }

        public Boleto PagarCon(Tarjeta tarjeta)
        {
            if (tarjeta.DescontarPasaje(Tarifa))
            {
                return new Boleto(linea, Tarifa);
            }

            return null;
        }
    }
}
}
