using System;
namespace Space
{
    public class Colectivo
    {

        public int tarifa;
        public int precio = 940;
        public string linea; 
        public string TipoTarjeta;


        public Colectivo(string linea1)
        {
            this.linea = linea1;
        }

        public bool Descontar(Tarjeta tarjeta)
        {

            if (tarjeta is GratuitoBoleto)
            {
                tarifa = 0;
                TipoTarjeta = "Boleto Gratuito";
            }
            else
            {

                if (tarjeta is MedioBoleto)
                {
                    tarifa = precio / 2;
                    TipoTarjeta = "Medio Boleto";
                }
                else
                {
                    tarifa = precio;
                    TipoTarjeta = "Medio Boleto";
                }
            }

            if (tarjeta.saldo - tarifa >= tarjeta.limite_neg)
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

            tarjeta.historial[tarjeta.historial.Length] = new Boleto(tarifa, linea, tarjeta.saldo, TipoTarjeta);
            return new Boleto(tarifa, linea, tarjeta.saldo, TipoTarjeta);

        }
        else
        {
            Console.WriteLine("No se pudo emitir el boleto.");
            return null;
        }
    }
}
}