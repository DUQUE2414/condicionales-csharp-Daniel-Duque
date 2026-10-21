// ### Problema 13. Códigos de país

// Un formulario web recibe un código de país de dos letras y debe guardar en una variable el nombre completo:

// - “CO” → Colombia · “MX” → México · “AR” → Argentina · “PE” → Perú · “CL” → Chile
// - Cualquier otro → `País no registrado`


Console.WriteLine("Ingrese el código del país (ej. CO, MX, AR):");
string pais = Console.ReadLine()!.Trim().ToUpper();

string codigo = pais switch
{
    "CO" => "Colombia",
    "MX" => "México",
    "AR" => "Argentina",
    "PE" => "Perú",
    "CL" => "Chile",
    _ => "País no registrado"
};

Console.WriteLine($"El país es: {codigo}");