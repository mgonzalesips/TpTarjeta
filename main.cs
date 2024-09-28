using System;

namespace TP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Colectivo CientoDos = new Colectivo("102");
            Tarjeta tarjeta;
            tarjeta = new Tarjeta(1974);
            tarjeta.CargarTarjeta(2000);
            CientoDos.pagarCon(tarjeta);
            tarjeta.MostrarSaldo();
        }
    }
}
