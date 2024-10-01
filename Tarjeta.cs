namespace TransporteUrbano
{
    public class Tarjeta
    {
        private decimal saldo;
        private const decimal LimiteSaldo = 9900m;
        private const decimal CostoPasaje = 940m; 
        private static readonly decimal[] MontosAceptados = { 2000, 3000, 4000, 5000, 6000, 7000, 8000, 9000 };

        public Tarjeta(decimal saldoInicial)
        {
            saldo = saldoInicial;
        }

        public bool CargarSaldo(decimal monto)
        {
            if (!MontosAceptados.Contains(monto))
            {
                return false;
            }

            if (saldo + monto > LimiteSaldo)
            {
                saldo = LimiteSaldo;
            }
            else
            {
                saldo += monto;
            }

            return true;
        }

        public bool DescontarPasaje()
        {
            if (saldo >= CostoPasaje)
            {
                saldo -= CostoPasaje;
                return true;
            }

            return false;
        }

        public decimal ObtenerSaldo()
        {
            return saldo;
        }
    }
}

}
