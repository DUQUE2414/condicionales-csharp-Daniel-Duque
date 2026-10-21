// ### Problema 27. Taquilla de cine

// El precio de la boleta depende de dos datos a la vez: el día (texto: “lunes” … “domingo”) 
// y si la persona es estudiante (sí/no).

// - Los martes la boleta cuesta $7.000 para todos.
// - De lunes a viernes (excepto martes), un estudiante paga $9.000 y un no estudiante $12.000.
// - Sábado y domingo cuesta $15.000 para todos.

// Ejemplos: (“martes”, no) → `$7.000` · (“jueves”, sí) → `$9.000` · (“jueves”, no) → `$12.000` · (“sábado”, sí) → `$15.000`


Console.WriteLine("Ingrese el día de la semana:");
string dia = Console.ReadLine()!.Trim().ToLower();

Console.WriteLine("¿Es estudiante? (si/no):");
bool esEstudiante = Console.ReadLine()!.Trim().ToLower() == "si";

int precio = (dia, esEstudiante) switch
{
    ("martes", _) => 7000,
    ("sabado" or "sábado" or "domingo", _) => 15000,
    ("lunes" or "miercoles" or "miércoles" or "jueves" or "viernes", true) => 9000,
    ("lunes" or "miercoles" or "miércoles" or "jueves" or "viernes", false) => 12000,
    _ => throw new ArgumentException("Día no válido")
};

Console.WriteLine($"Precio de la boleta: ${precio:N0}");