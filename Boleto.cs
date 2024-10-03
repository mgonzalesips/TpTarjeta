using System;

namespace Space
{
    public class Boleto
    {
        private int tarifa;
        private string linea;
        private int saldoRestante;

        public Boleto(int precio, string linea1, int saldoRestante)
        {
            this.tarifa = precio;
            this.linea = linea1;
            this.saldoRestante = saldoRestante;
        }
    }
}
