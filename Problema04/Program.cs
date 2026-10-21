Console.WriteLine("Ingrese el porcentaje de la batería:");
int bateria = int.Parse(Console.ReadLine()!);

if (bateria < 15)
{
    Console.WriteLine("Batería baja: conecte el cargador");
}

Console.WriteLine($"Nivel actual: {bateria} %");