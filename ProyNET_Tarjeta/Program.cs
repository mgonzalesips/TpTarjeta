// See https://aka.ms/new-console-template for more information
using System;
using Iteraciones;
class Program {
  public static void Main (string[] args) {
    Console.WriteLine("\n Test tarjeta queda con $300 de saldo negativo");
    TarjetaComun tarjetaSN = new TarjetaComun(640);
    Console.WriteLine(tarjetaSN.Saldo);
    Colectivo bondi = new Colectivo();
    bondi.pagarCon(tarjetaSN);
    Console.WriteLine(tarjetaSN.Saldo);
    tarjetaSN.cargarTarjeta(2000);
    Console.WriteLine(tarjetaSN.Saldo); //deberia de dar 1700 = 2000-300

    Console.WriteLine("\n Test tarjeta no puede pagar");
    TarjetaComun tarjetaSN1 = new TarjetaComun(450);
    Console.WriteLine(tarjetaSN1.Saldo);
    if(bondi.pagarCon(tarjetaSN1) == null)
      Console.WriteLine("No pudo pagar el boleto");
  
    Console.WriteLine("Test franquicia completa \n");
    FranquiciaCompleta tarjeta1 = new FranquiciaCompleta(0);
    Console.WriteLine(tarjeta1.Saldo);
    Colectivo bondi1 = new Colectivo();
    bondi1.pagarCon(tarjeta1);
    if (bondi1.pagarCon(tarjeta1) != null)
        Console.WriteLine("Boleto se creo exitosamente");
    Console.WriteLine(tarjeta1.Saldo);

    Console.WriteLine("\nTest medio boleto \n");
    MedioBoleto tarjeta2 = new MedioBoleto(500);
    Console.WriteLine(tarjeta2.Saldo);
    int saldo_previo = tarjeta2.Saldo;
    Colectivo bondi2 = new Colectivo();
    bondi2.pagarCon(tarjeta2);
    Console.WriteLine(tarjeta2.Saldo);
    Console.WriteLine(saldo_previo - tarjeta2.Saldo); //da el valor del pasaje deberia ser 470 (940/2)

    Console.WriteLine("\n Test nuevos campos de boletos");
    TarjetaComun tarjetaC = new TarjetaComun(500);
    Colectivo cole = new Colectivo("212");
    Boleto boleto = cole.pagarCon(tarjetaC);
    tarjetaC.cargarTarjeta(2000);
    Console.WriteLine($"Fecha pago:{boleto.GetFecha()} \n Tipo tarjeta usada:{boleto.GetTipoTarjeta()} \n");
    Console.WriteLine($"LineaColectivo:{boleto.GetLineaColectivo()}\n Total Pagado:{boleto.GetTotalPagar()}\n");
    Console.WriteLine($"Saldo tarjeta:{boleto.GetSaldo()}\n Id tarjeta:{boleto.GetIdTarjeta()}");
    Console.WriteLine($"{boleto.Descripcion}");
    Boleto boleto2 = cole.pagarCon(tarjetaC);
    Console.WriteLine($"Fecha pago:{boleto2.GetFecha()} \n Tipo tarjeta usada:{boleto2.GetTipoTarjeta()} \n");
    Console.WriteLine($"LineaColectivo:{boleto2.GetLineaColectivo()}\n Total Pagado:{boleto2.GetTotalPagar()}\n");
    Console.WriteLine($"Saldo tarjeta:{boleto2.GetSaldo()}\n Id tarjeta:{boleto2.GetIdTarjeta()}");
    Console.WriteLine($"{boleto2.Descripcion}");

    Console.WriteLine("\n Test acreditación pendiente");
    TarjetaComun tarjetaC1 = new TarjetaComun(36500);
    Console.WriteLine($"Por acreditar:{tarjetaC1.AcreditaciónPendiente}");
    TarjetaComun tarjetaC2 = new TarjetaComun(34500);
    tarjetaC2.cargarTarjeta(4000);
    cole.pagarCon(tarjetaC2);
    Console.WriteLine($"Por acreditar:{tarjetaC2.AcreditaciónPendiente}\n Saldo de la tarjeta:{tarjetaC2.Saldo}\n");

    Console.WriteLine("\n Test medio boleto actualizado");
    MedioBoleto tarjetaMB1 = new MedioBoleto(10000);
    Boleto boletoMB1 = cole.pagarCon(tarjetaMB1);
    Boleto boletoMB2 = cole.pagarCon(tarjetaMB1);
    if(boletoMB2 == null)
      Console.WriteLine("No se pudo pagar el pasaje debido al limite de 5mins");

    Console.WriteLine("\n Test medio boleto actualizado");
    FranquiciaCompleta tarjetaFC1 = new FranquiciaCompleta(0);
    Boleto boletoFC1 = cole.pagarCon(tarjetaFC1);
    if (boletoFC1 != null)
      Console.WriteLine("boleto pago exitosamente");
      Console.WriteLine($"boleto {tarjetaFC1.CantUsosHoy} ,descuento franquicia: {tarjetaFC1.Descuento_franquicia}");
    Boleto boletoFC2 = cole.pagarCon(tarjetaFC1);
    if (boletoFC2 != null)
      Console.WriteLine("boleto pago exitosamente");
      Console.WriteLine($"boleto {tarjetaFC1.CantUsosHoy} ,descuento franquicia: {tarjetaFC1.Descuento_franquicia}");
    Boleto boletoFC3 = cole.pagarCon(tarjetaFC1);
    if (boletoFC3 != null)
      Console.WriteLine("boleto pago exitosamente");
    if (boletoFC3 == null)
      Console.WriteLine("boleto no fue creado ya que el segundo viaje dejo de ser gratis");
    Console.WriteLine($"boleto {tarjetaFC1.CantUsosHoy} ,descuento franquicia: {tarjetaFC1.Descuento_franquicia}");
  }
}