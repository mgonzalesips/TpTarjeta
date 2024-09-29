using System;
using BoletoNamespace;
using ColectivoNamespace;
using TarjetaNamespace;

class Program
{

    public static void Main(string[] args)
    {
        boleto boleto = new boleto();
        colectivo colectivo = new colectivo();
        tarjeta tarjeta = null;

        while (true)
        {
            Console.WriteLine("Tipo de tarjeta a usar: ");
            Console.WriteLine("1 Normal");
            Console.WriteLine("2 Medio Boleto");
            Console.WriteLine("3 Franquicia Completa");
            string tipo_tarjeta = Console.ReadLine();

            switch (tipo_tarjeta)
            {
                case "1":
                    tarjeta = new tarjeta();
                    break;
                case "2":
                    tarjeta = new MedioBoleto();
                    break;
                case "3":
                    tarjeta = new FranquiciaCompleta();
                    break;

                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
            break;

        }


        while (true)
        {
            Console.WriteLine("Ingrese una opcion");
            Console.WriteLine("1: Cargar saldo");
            Console.WriteLine("2: Pagar boleto");
            Console.WriteLine("saldo actual: " + tarjeta.saldo);
            
            string opcion = Console.ReadLine();
            {
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el monto a cargar");
                        int monto = int.Parse(Console.ReadLine());
                        tarjeta.cargarSaldo(monto);
                        break;
                    case "2":
                        colectivo.PagarCon(tarjeta);
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
            }
        }
    }
}
