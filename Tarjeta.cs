using System;
namespace Space
{
    public class Tarjeta
    {
        public int saldo;
        public int id;
        public int saldo_max = 9900;
        public int limite_neg = -480;
        public int[] montos_posibles = new int[] { 2000, 3000, 4000, 5000, 6000, 7000, 8000, 9000 };
        public Boleto[] historial;

        public Tarjeta(int id)
        {
            this.id = id;
            saldo = 0; 
            historial = new Boleto[100]; 
        }

        public void Cargar_tarjeta(int monto)
        {
            if (monto + saldo > saldo_max)
            {
                Console.WriteLine("El monto a cargar excede a " + saldo_max);
            }
            else
            {
                bool monto_valido = false;
                foreach (int monto_posible in montos_posibles)
                {
                    if (monto_posible == monto)
                    {
                        saldo += monto;
                        monto_valido = true;
                        break;
                    }
                }
                if (!monto_valido)
                {
                    Console.WriteLine("El monto a cargar no es posible");
                }
            }
        }
    }
}
