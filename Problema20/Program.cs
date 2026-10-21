// ### Problema 20. Días de cada mes

// Dado el número de un mes (1 a 12) de un año no bisiesto, imprime cuántos días tiene. 
// Varios meses comparten la misma cantidad de días. Un número fuera de rango imprime `Mes inválido`.

// - 4 → `30 días` · 2 → `28 días` · 12 → `31 días` · 13 → `Mes inválido`

Console.WriteLine("Ingrese el número del mes (1 a 12):");
int mes = int.Parse(Console.ReadLine()!.Trim());

string resultado = mes switch
{
    1 or 3 or 5 or 7 or 8 or 10 or 12 => "31 días",
    4 or 6 or 9 or 11 => "30 días",
    2 => "28 días",
    _ => "Mes inválido"
};

Console.WriteLine(resultado);