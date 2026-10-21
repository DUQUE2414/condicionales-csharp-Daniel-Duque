// ### Problema 28. Descuento por compra

// Un almacén aplica descuentos según el valor de la compra:

// - $500.000 o más: 15 %
// - $200.000 a menos de $500.000: 10 %
// - $100.000 a menos de $200.000: 5 %
// - Menos de $100.000: sin descuento

// Además, si el cliente está inscrito en el programa de cliente frecuente y 
// la compra es de $100.000 o más, recibe un 5 % adicional. El programa muestra el valor de la compra, 
// el porcentaje total de descuento y el total a pagar.

// - $250.000, frecuente → descuento 15 %, total $212.500
// - $250.000, no frecuente → descuento 10 %, total $225.000
// - $80.000, frecuente → descuento 0 %, total $80.000

Console.WriteLine("Ingrese el valor de la compra:");
decimal valorCompra = decimal.Parse(Console.ReadLine()!.Trim());

Console.WriteLine("¿El cliente es frecuente? (si/no):");
bool esFrecuente = Console.ReadLine()!.Trim().ToLower() == "si";

int porcentajeBase = valorCompra switch
{
    >= 500000m => 15,
    >= 200000m => 10,
    >= 100000m => 5,
    _ => 0
};

int porcentajeAdicional = (esFrecuente && valorCompra >= 100000m) ? 5 : 0;
int porcentajeTotal = porcentajeBase + porcentajeAdicional;

decimal totalAPagar = valorCompra * (1m - (porcentajeTotal / 100m));

Console.WriteLine($"Valor compra: ${valorCompra:N0}");
Console.WriteLine($"Descuento total: {porcentajeTotal}%");
Console.WriteLine($"Total a pagar: ${totalAPagar:N0}");