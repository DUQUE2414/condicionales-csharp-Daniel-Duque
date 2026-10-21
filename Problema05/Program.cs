// ### Problema 5. El mayor de dos números

// Dados dos números enteros, guarda en una variable `mayor` el más grande de los dos usando 
// una sola línea de asignación, y luego imprímelo.

// - Entrada: 14 y 9 → `El mayor es 14`
// - Entrada: -2 y 3 → `El mayor es 3`
Console.WriteLine("Ingrese el valor de a:");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Ingrese el valor de b:");
int b = int.Parse(Console.ReadLine()!);

int mayor = (a > b) ? a : b;

Console.WriteLine($"El mayor es {mayor}");