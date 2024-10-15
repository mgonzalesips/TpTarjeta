# Trabajo Tarjeta: Versión 2024
El siguiente trabajo es un enunciado iterativo. Todas las semanas nuevos requerimientos serán agregados y/o modificados para ilustrar la dinámica de desarrollo de software.
## Iteración 1.
Escribir un programa con programación orientada a objetos que permita ilustrar el funcionamiento del transporte urbano de pasajeros de la ciudad de Rosario.

Las clases que interactúan en la simulación son: Colectivo, Tarjeta y Boleto.

Cuando un usuario viaja en colectivo con una tarjeta, obtiene un boleto como resultado de la operación __colectivo.pagarCon(tarjeta);__

Para esta iteración se consideran los siguientes supuestos:
- No hay medio boleto de ningún tipo.
- No hay transbordos.
- No hay saldo negativo.
- La tarifa básica de un pasaje es de: $940
- Las cargas aceptadas de tarjetas son: (2000, 3000, 4000, 5000, 6000, 7000, 8000, 9000)
- El límite de saldo de una tarjeta es de $9900
  
Se pide:

- Hacer un fork del repositorio.
- Implementar el código de las clases Tarjeta, Colectivo y Boleto.
- Hacer que el test Tarjeta.cs funcione correctamente con todos los montos de pago listados.
- Enviar el enlace del repositorio a este [formulario](https://forms.gle/sZV7b9o1jTqR5nSL9) con los integrantes del grupo. __Solo dos por grupo__.

## Iteración 2.
Para esta iteración hay 3 tareas principales. Crear un [issue](https://docs.github.com/es/issues/tracking-your-work-with-issues/creating-an-issue) en github copiando la descripción de cada tarea y completar cada uno en una rama diferente. Éstas serán mergeadas al validar, luego de una revisión cruzada (de ambos integrantes del grupo), que todo el código tiene sentido y está correctamente implementado.
No es necesario que todo el código para un issue esté funcionando al 100% antes de mergiarlo, pueden crear pull requests que solucionen algún item particular del problema para avanzar más rápido.
Además de las tareas planteadas, cada grupo tiene tareas pendientes de la iteración anterior que debe finalizar antes de comenzar con la iteración 2. Cuando la iteración 1 esté completada, crear un [tag](https://www.youtube.com/watch?v=5DkX3HFgklM) llamado iteracion1 y subirlo a github.

## Descuento de saldos.
- Cada vez que una tarjeta paga un boleto, descuenta el valor del monto gastado.
- Si la tarjeta se queda sin saldo, la operación colectivo.pagarCon(tarjeta) no debe permitir que se cobre el viaje.
- Escribir un test que valide dos casos, pagar con saldo y pagar sin saldo.

## Saldo negativo
- Si la tarjeta se queda sin crédito, puede tener un saldo negativo de hasta $480.
- Cuando se vuelve a cargar la tarjeta, se descuenta el saldo de lo que se haya consumido en concepto de viaje plus.
- Escribir un test que valide que la tarjeta no pueda quedar con menos saldo que el permitido.
- Escribir un test que valide que el saldo de la tarjeta descuenta correctamente el saldo adeudado.

## Franquicia de Boleto.
- Existen dos tipos de franquicia en lo que refiere a tarjetas, las franquicias parciales, como el medio boleto estudiantil o el universitario, y las completas como las de jubilados(Notar que también existe boleto gratuito para estudiantes).
- Implementar cada tipo de tarjeta como una Herencia de la tarjeta original.
- Para esta iteración considerar simplemente que cuando se paga con una tarjeta del tipo MedioBoleto el costo del pasaje vale la mitad, independientemente de cuántas veces se use y que día de la semana sea.
- Escribir un test que valide que una tarjeta de FranquiciaCompleta siempre puede pagar un boleto.
- Escribir un test que valide que el monto del boleto pagado con medio boleto es siempre la mitad del normal.

# Iteracion 3.
Al igual que la iteración anterior, se pide mantener la mecánica de trabajo para ir añadiendo las nuevas funcionalidades y/o modificaciones (issue, una rama específica para cada tarea y finalmente el mergeo cuando todo funcione correctamente..., etc.)
En esta iteración daremos una introducción a la manipulación de fechas y horarios. Éstos serán necesarios en esta oportunidad para realizar las modificaciones pedidas.
## Más datos sobre el boleto.
La clase boleto tendrá nuevos métodos que permitan conocer: (Fecha, tipo de tarjeta, línea de colectivo, total abonado, saldo e ID de la tarjeta). El boleto deberá indicar además el saldo restante en la tarjeta.
- Además el boleto tiene una descripción extra indicando si se canceló el saldo negativo con el pago de este boleto (Ejemplo: Abona saldo 120).
- Escribir los tests correspondientes a los posibles tipos de boletos a obtener según el tipo de tarjeta.

# Limitación en el pago de medio boletos
Para evitar el uso de una tarjeta de tipo medio boleto en más de una persona en el mismo viaje se pide que:
- Al utilizar una tarjeta de tipo medio boleto para viajar, deben pasar como mínimo 5 minutos antes de realizar otro viaje. No será posible pagar otro viaje antes de que pasen estos 5 minutos.
- Escribir un test que verifique efectivamente que no se deje marcar nuevamente al intentar realizar otro viaje en un intervalo menor a 5 minutos con la misma tarjeta medio boleto. Para el caso del medio boleto, se pueden realizar hasta cuatro viajes por día. El quinto viaje ya posee su valor normal.
- Escribir un test que verifique que no se puedan realizar más de cuatro viajes por día con medio boleto.

# Limitación en el pago de franquicias completas.
Para evitar el uso de una tarjeta de tipo boleto educativo gratuito en más de una persona en el mismo viaje se pide que:
- Al utilizar una tarjeta de tipo boleto educativo gratuito se pueden realizar hasta 2 viajes gratis por día.
- Escribir un test que verifique que no se puedan realizar más de dos viajes gratuitos por día.
- Escribir un test que verifique que los viajes posteriores al segundo se cobran con el precio completo.

# Saldo de la tarjeta.
Una tarjeta SUBE no puede almacenar más de 36000 pesos. Por lo tanto cuando se realiza una carga que haga que se supere este límite, se deberá acreditar la carga en la tarjeta hasta alcanzar el monto máximo permitido y el monto restante se deberá dejar pendiente de acreditación. Luego ese saldo pendiente se acredita a medida que se usa la tarjeta.
- Modificar la función para cargar la tarjeta añadiendo esta funcionalidad.
- Escribir un test que valide que si a una tarjeta se le carga un monto que supere el máximo permitido, se acredite el saldo hasta alcanzar el máximo(6600) y que el excedente quede almacenado y pendiente de acreditación.
- Escribir un test que valide que luego de realizar un viaje, verifique si hay saldo pendiente de acreditación y recargue la tarjeta hasta llegar al máximo nuevamente.

# Iteracion 4.

El boleto de colectivo aumento su tarifa a $1200. Actualizar la tarifa de los colectivos.

# Boleto de uso frecuente
Las tarjetas SUBE cuentan con el boleto de uso frecuente. Este es un beneficio que aplica un descuento al monto del boleto dependiendo de cuántos viajes se hagan.
- Del viaje 1 al 29: Tarifa normal.
- Del viaje 30 al 79: 20% de descuento.
- Del viaje 79 al 80: 25% de descuento.
- Del viaje 81 en adelante: Tarifa normal.

La cantidad de viajes se cuenta del primer al ultimo dia de cada mes. Este beneficio se aplicará *sólo* sobre las tarjetas normales.
Implementar esta nueva funcionalidad.
Escribir los test correspondientes para validar el correcto funcionamiento del código.
# Franquicias
Todas las franquicias(medio boleto estudiantil, jubilado, medio boleto universitario y boleto educativo gratuito) solo pueden utilizarse en una determinada franja horaria:

Lunes a viernes de 6 a 22. 

Fuera de este intervalo de tiempo no es posible pagar con ninguna de estas franquicias.
Escribir tests que validen que no se puedan realizar viajes fuera de la franja horaria y/o días correspondientes.

# Líneas interurbanas
En nuestra ciudad existen diversas líneas de colectivo. Algunas solo viajan dentro de la ciudad pero otras van hacia la zona metropolitana de Rosario(ej: Galvez, Baigorria). Estas líneas tienen otra tarifa.

Implementar las líneas de colectivo interurbanas.
La tarifa interurbana es de: $2500.

Las líneas de colectivo interurbanas admiten todas las franquicias y siguen los mismos criterios que las líneas de colectivo urbanas.

