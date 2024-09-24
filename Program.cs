using System;
using TransporteUrbano;

class Program
{
    static void Main(string[] args)
    {
        // Crear una tarjeta con un saldo inicial
        Tarjeta tarjeta = new Tarjeta(3000);

        // Crear un colectivo (ejemplo línea 123)
        Colectivo colectivo = new Colectivo("123");

        // Pagar un pasaje
        Boleto boleto = colectivo.PagarCon(tarjeta);

        if (boleto != null)
        {
            Console.WriteLine("Pasaje pagado exitosamente.");
            Console.WriteLine(boleto.ToString());
        }
        else
        {
            Console.WriteLine("No se pudo pagar el pasaje. Saldo insuficiente.");
        }

        Console.WriteLine($"Saldo restante en la tarjeta: {tarjeta.ObtenerSaldo()}");
    }
}
