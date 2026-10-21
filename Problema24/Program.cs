// ### Problema 24. ¿Día hábil?

// Dado el número de un día de la semana (1 = lunes … 7 = domingo), 
// guarda en una variable si es `Día hábil` (lunes a viernes) o `Fin de semana` (sábado y domingo). 
// Cualquier otro número es `Día inválido`.

// - 3 → `Día hábil` · 7 → `Fin de semana` · 0 → `Día inválido`

Console.WriteLine("Ingrese el número del día (1 a 7):");
int dia = int.Parse(Console.ReadLine()!.Trim());

string resultado = dia switch
{
    >= 1 and <= 5 => "Día hábil",
    6 or 7 => "Fin de semana",
    _ => "Día inválido"
};

Console.WriteLine(resultado);