using System;
using BoletoNamespace;

namespace TarjetaNamespace {

  public class tarjeta {
  public int saldo;
  public int limite = 9900;

  public void cargarSaldo(int monto){
    if (monto <= limite && (monto == 2000 || monto == 3000|| monto == 4000|| monto == 5000|| monto == 6000|| monto == 7000|| monto == 8000|| monto == 9000)){
      saldo += monto;
    }else{
      Console.WriteLine("El monto no es valido");
    }
  }

  public virtual int precioBoleto(int precio){
    return precio;
  }
}

  public class MedioBoleto : tarjeta {
    public override int precioBoleto(int precio){
      return precio/2;
    }
  }

  public class FranquiciaCompleta : tarjeta {
    public override int precioBoleto(int precio){
      return 0;
    }
  }
}
