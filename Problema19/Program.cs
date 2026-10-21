// ### Problema 19. Radar de velocidad

// Un radar en una vía urbana con límite de 50 km/h clasifica la velocidad medida y guarda la sanción en una variable:

// - Menos de 0: `Lectura inválida`
// - De 0 a 50: `Sin infracción`
// - Más de 50 hasta 70: `Multa leve`
// - Más de 70 hasta 90: `Multa grave`
// - Más de 90: `Multa gravísima e inmovilización`

// Ejemplos: 45 → `Sin infracción` · 68 → `Multa leve` · 95 → `Multa gravísima e inmovilización`

Console.WriteLine("Ingrese la velocidad registrada (km/h):");
double velocidad = double.Parse(Console.ReadLine()!.Trim());

string sancion = velocidad switch
{
    < 0 => "Lectura inválida",
    <= 50 => "Sin infracción",
    > 50 and <= 70 => "Multa leve",
    > 70 and <= 90 => "Multa grave",
    _ => "Multa gravísima e inmovilización"
};

Console.WriteLine(sancion);