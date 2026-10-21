// ### Problema 8. Vocal o consonante

// Lee una letra minúscula e indica si es vocal (a, e, i, o, u) o consonante. 
// Si el carácter no es una letra del alfabeto, debe mostrar `No es una letra`.

// - ‘e’ → `Es vocal` · ‘m’ → `Es consonante` · ‘7’ → `No es una letra`

Console.WriteLine("Ingrese una letra:");
char letra = char.Parse(Console.ReadLine()!.ToLower());

if (!char.IsLetter(letra))
{
    Console.WriteLine("No es una letra");
}
else if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
{
    Console.WriteLine("Es vocal");
}
else
{
    Console.WriteLine("Es consonante");
}