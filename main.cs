using System;

namespace TP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Colectivo CientoDos = new Colectivo("102");
            Tarjeta tarjeta;
            tarjeta = new Tarjeta(2000);
            tarjeta.CargarTarjeta(9000);
            CientoDos.Pasaje(tarjeta);
            tarjeta.MostrarSaldo();
        }
    }
}
