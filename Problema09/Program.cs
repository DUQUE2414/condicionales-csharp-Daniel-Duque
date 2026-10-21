// ### Problema 9. Año bisiesto

// Un año es bisiesto si es divisible entre 4 y no entre 100, o 
// si es divisible entre 400. Determina si un año dado es bisiesto.

// - 2024 → `Bisiesto` · 1900 → `No bisiesto` · 2000 → `Bisiesto`


Console.WriteLine("Ingrese un año:");
int year = int.Parse(Console.ReadLine()!);

if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
{
    Console.WriteLine("Bisiesto");
}
else
{
    Console.WriteLine("No bisiesto");
}