using System;

namespace TP
{
    public class Tarjeta
    {
        private float saldo;
        public int id;

        private float limite = 9900;
        private float[] montos_disponibles = { 2000, 3000, 4000, 5000, 6000, 7000, 8000, 9000 };

        public Tarjeta(int id)
        {
            this.id = id;
        }

        public void CargarTarjeta(float monto)
        {
            if (Array.Exists(montos_disponibles, x => x == monto))
            {
                if ((saldo + monto) < limite)
                {
                    saldo += monto;
                    Console.WriteLine("Saldo Actual: " + saldo);
                }
                else
                    Console.WriteLine("El monto excede el limite de la tarjeta");
            }
        }



        public void MostrarSaldo()
        {
            Console.Write("Saldo : " + saldo);
        }

        public float VerSaldo()
        {
            return saldo;
        }
        public float RestarSaldo(float monto){
            return saldo -= monto;
        }
    }
}