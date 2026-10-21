// Problema 30. Boletín de calificaciones (integrador)
// Un instructor registra tres notas de un aprendiz (0 a 100). El programa debe:

// Calcular el promedio.
// Convertir el promedio a letra: 90 o más → A, 80 a 89 → B, 70 a 79 → C, 60 a 69 → D, menos de 60 → F.
// Según la letra, imprimir un mensaje de retroalimentación: A → Desempeño excelente; B o C → Buen desempeño, sigue así; 
// D → Aprobado, refuerza los temas; F → Debe presentar plan de mejoramiento.
// Indicar Aprobado o Reprobado (aprueba con 60 o más).
// Si el promedio es exactamente 100, mostrar adicionalmente ¡Mención de honor!.
// Ejemplo: notas 85, 78, 92 → Promedio: 85,0 | Letra: B | Buen desempeño, sigue así | Aprobado

Console.WriteLine("Ingrese la primera nota (0 a 100):");
double nota1 = double.Parse(Console.ReadLine()!.Trim());

Console.WriteLine("Ingrese la segunda nota (0 a 100):");
double nota2 = double.Parse(Console.ReadLine()!.Trim());

Console.WriteLine("Ingrese la tercera nota (0 a 100):");
double nota3 = double.Parse(Console.ReadLine()!.Trim());

if (nota1 is < 0 or > 100 || nota2 is < 0 or > 100 || nota3 is < 0 or > 100)
{
    Console.WriteLine("Error: Las notas deben estar dentro del rango de 0 a 100.");
    return;
}

double promedio = (nota1 + nota2 + nota3) / 3.0;

char letra = promedio switch
{
    >= 90 => 'A',
    >= 80 => 'B',
    >= 70 => 'C',
    >= 60 => 'D',
    _ => 'F'
};

string retroalimentacion = letra switch
{
    'A' => "Desempeño excelente",
    'B' or 'C' => "Buen desempeño, sigue así",
    'D' => "Aprobado, refuerza los temas",
    'F' => "Debe presentar plan de mejoramiento",
    _ => throw new InvalidOperationException("Letra de calificación inválida")
};

string estado = promedio >= 60 ? "Aprobado" : "Reprobado";

Console.WriteLine($"\nPromedio: {promedio:F1} | Letra: {letra} | {retroalimentacion} | {estado}");

if (promedio == 100)
{
    Console.WriteLine("¡Mención de honor!");
}