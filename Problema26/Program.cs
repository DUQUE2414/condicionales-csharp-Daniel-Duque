// ### Problema 26. Peaje

// Un peaje identifica el vehículo con una letra y asigna la tarifa a cobrar:

// - ‘M’ moto: $0 (exenta)
// - ‘A’ automóvil: $12.000
// - ‘B’ bus: $25.000
// - ‘C’ camión: $38.000
// - Otra letra: se lanza una excepción con el mensaje `Categoría desconocida`

// Imprime `Categoría X - Tarifa: $Y`.

using System;

Console.WriteLine("Ingrese la letra del vehículo (M, A, B, C):");
char tipoVehiculo = char.ToUpper(char.Parse(Console.ReadLine()!.Trim()));

try
{
    int tarifa = tipoVehiculo switch
    {
        'M' => 0,
        'A' => 12000,
        'B' => 25000,
        'C' => 38000,
        _ => throw new ArgumentException("Categoría desconocida")
    };

    string nombreCategoria = tipoVehiculo switch
    {
        'M' => "moto",
        'A' => "automóvil",
        'B' => "bus",
        'C' => "camión",
        _ => throw new ArgumentException("Categoría desconocida")
    };

    Console.WriteLine($"Categoría {nombreCategoria} - Tarifa: ${tarifa:N0}");
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}