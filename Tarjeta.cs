using System;

namespace TpSube {
  public class Tarjeta {
    private const float saldo_max = 9900;
    private const float saldo_negativo_max = -480;
    
    public float saldo { get; protected set; }

    public Tarjeta(float saldo_inicial) {
      if (saldo_inicial > saldo_max) {
        saldo = saldo_max;
        Console.WriteLine("Saldo inicial excede el saldo máximo, se ha cargado $9900"); 
      } else {
        saldo = saldo_inicial;
      }
    }
    
    public void actualizar_saldo(float monto_a_actualizar){
      saldo = saldo - monto_a_actualizar;
    }  

    public bool CargarSaldo(float monto_carga) {
      if (EsCargaValida(monto_carga)) {
        if (saldo < 0) {
          float deuda = Math.Abs(saldo);
          if (monto_carga > deuda) {
            saldo = monto_carga - deuda;  
            Console.WriteLine($"Se descontaron ${deuda} de la deuda. Su nuevo saldo es de ${saldo}");
          } else {
            saldo += monto_carga;  
            Console.WriteLine($"Se descontaron ${monto_carga} de la deuda. Su deuda restante es de ${Math.Abs(saldo)}");
          }
        } else {
          saldo += monto_carga; 
        }
        if (saldo > saldo_max) {
          float monto_sobrante = saldo - saldo_max;
          saldo = saldo_max;
          Console.WriteLine($"Saldo máximo excedido por ${monto_sobrante}");
          return false;
        }
        Console.WriteLine($"Su tarjeta ha sido cargada, su saldo es de ${saldo}");
        return true;
      }
      return false;
    }

    private bool EsCargaValida(float monto_carga) {
      return monto_carga == 2000 || monto_carga == 3000 || monto_carga == 4000 ||
             monto_carga == 5000 || monto_carga == 6000 || monto_carga == 7000 ||
             monto_carga == 8000 || monto_carga == 9000;
    }
  }

  public class MedioBoleto : Tarjeta {
    public MedioBoleto(float saldo_inicial) : base(saldo_inicial) {}

  }

  public class GratuitoJubilados : Tarjeta {
    public GratuitoJubilados(float saldo_inicial) : base(saldo_inicial) {}
  }

  public class GratuitoEstudiantes : Tarjeta {
    public GratuitoEstudiantes(float saldo_inicial) : base(saldo_inicial) {}
  }
}
