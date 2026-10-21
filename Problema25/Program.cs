// ### Problema 25. Calidad del aire

// Una estación de monitoreo recibe el índice de calidad del aire (ICA, entero) y debe asignar la categoría:

// - 0 a 50: Buena
// - 51 a 100: Moderada
// - 101 a 150: Dañina para grupos sensibles
// - 151 a 200: Dañina
// - Más de 200: Muy dañina
// - Negativo: Valor inválido

// Ejemplos: 35 → `Buena` · 120 → `Dañina para grupos sensibles` · 260 → `Muy dañina`

Console.WriteLine("Ingrese el índice de calidad del aire (ICA):");
int ica = int.Parse(Console.ReadLine()!.Trim());

string categoria = ica switch
{
    < 0 => "Valor inválido",
    <= 50 => "Buena",
    <= 100 => "Moderada",
    <= 150 => "Dañina para grupos sensibles",
    <= 200 => "Dañina",
    _ => "Muy dañina"
};

Console.WriteLine(categoria);