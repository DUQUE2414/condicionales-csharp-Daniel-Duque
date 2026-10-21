// ### Problema 22. Calculadora básica

// Recibe dos números enteros y un operador (`+`, `-`, `*`, `/`) y 
// guarda el resultado de la operación en una variable. Si se intenta dividir entre cero, 
// el programa debe lanzar una excepción con el mensaje `No se puede dividir entre cero`. 
// Si el operador no es válido, debe lanzar una excepción con el mensaje `Operador no soportado`.

// - 12, 4, ‘*’ → `12 * 4 = 48`
// - 10, 0, ‘/’ → excepción `No se puede dividir entre cero`
// - 5, 2, ‘%’ → excepción `Operador no soportado`


using System;

Console.WriteLine("Ingrese el primer número entero:");
int num1 = int.Parse(Console.ReadLine()!.Trim());

Console.WriteLine("Ingrese el segundo número entero:");
int num2 = int.Parse(Console.ReadLine()!.Trim());

Console.WriteLine("Ingrese el operador (+, -, *, /):");
string operador = Console.ReadLine()!.Trim();

try
{
    int resultado;

    if (operador == "+")
    {
        resultado = num1 + num2;
    }
    else if (operador == "-")
    {
        resultado = num1 - num2;
    }
    else if (operador == "*")
    {
        resultado = num1 * num2;
    }
    else if (operador == "/")
    {
        if (num2 == 0)
        {
            throw new DivideByZeroException("No se puede dividir entre cero");
        }
        resultado = num1 / num2;
    }
    else
    {
        throw new ArgumentException("Operador no soportado");
    }

    Console.WriteLine($"{num1} {operador} {num2} = {resultado}");
}
catch (Exception ex)
{
    Console.WriteLine($"Excepción: {ex.Message}");
}