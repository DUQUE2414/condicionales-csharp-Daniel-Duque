// ### Problema 18. Montaña rusa

// Para subir a la montaña rusa, una persona debe medir al menos 1,40 m y además tener 12 años o más, 
// a menos que vaya acompañada por un adulto, en cuyo caso basta con la estatura. Determina si puede subir.

// - Estatura 1,50, edad 13, sin acompañante → `Puede subir`
// - Estatura 1,45, edad 10, con acompañante → `Puede subir`
// - Estatura 1,45, edad 10, sin acompañante → `No puede subir`
// - Estatura 1,30, edad 15, con acompañante → `No puede subir`

Console.WriteLine("Ingrese la estatura en metros (ej. 1,45):");
double estatura = double.Parse(Console.ReadLine()!.Trim());

Console.WriteLine("Ingrese la edad:");
int edad = int.Parse(Console.ReadLine()!.Trim());

Console.WriteLine("¿Va acompañado por un adulto? (si/no):");
bool acompanado = Console.ReadLine()!.Trim().ToLower() == "si";

if (estatura >= 1.40 && (edad >= 12 || acompanado))
{
    Console.WriteLine("Puede subir");
}
else
{
    Console.WriteLine("No puede subir");
}