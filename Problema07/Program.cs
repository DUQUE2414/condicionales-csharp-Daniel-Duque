// ### Problema 7. Signo de un número

// Lee un número entero e indica si es positivo, negativo o cero.

// - 8 → `Positivo` · -5 → `Negativo` · 0 → `Cero`

Console.WriteLine("Ingrese un numero");
int numero = int.Parse(Console.ReadLine()!);

if (numero > 0)
{
    Console.WriteLine("Positivo");
}
else if (numero < 0)
{
    Console.WriteLine("Negativo");
}
else
{
    Console.WriteLine("Cero");
}