// ### Problema 10. Analizador de datos recibidos

// Un sistema recibe datos en una variable de tipo `object` que puede contener un texto, 
// un entero, un decimal (`double`) o un valor booleano. El programa debe describir el dato:

// - Texto → `Texto de N caracteres`
// - Entero → `Entero: valor`
// - Decimal → `Decimal: valor`
// - Booleano → `Booleano: valor`
// - Otro → `Tipo no reconocido`

// Ejemplos: “SENA” → `Texto de 4 caracteres` · 42 → `Entero: 42` · true → `Booleano: True`


object objeto = 10.1;

string descripcion = objeto switch
{
    int n => $"Es un numero entero con valor: {n}",
    double d => $"Es un numero decimal con valor: {d}",
    string s => $"Es un texto que dice: {s}",
    bool b => $"Es un booleano de valor: {b}",
    _ => "Tipo de dato no reconocido"
};

Console.WriteLine(descripcion);

