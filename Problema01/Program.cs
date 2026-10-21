// ### Problema 1. Registro electoral

// La Registraduría necesita un programa que reciba la edad de una persona e informe si puede votar 
// (16 años o más en este ejercicio) o si todavía no puede hacerlo.

// - Entrada: 17 → Salida: `Puede votar`
// - Entrada: 15 → Salida: `Aún no puede votar`

Console.WriteLine("Que edad tienes?");
int edad = int.Parse(Console.ReadLine()!);

if(edad >= 16)
{
    Console.WriteLine("Puedes votar");
}
else{
    Console.WriteLine("No puedes votar");
}
