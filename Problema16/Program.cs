Console.WriteLine("Ingrese la coordenada X:");
int ejeX = int.Parse(Console.ReadLine()!.Trim());

Console.WriteLine("Ingrese la coordenada Y:");
int ejeY = int.Parse(Console.ReadLine()!.Trim());

string ubicacion = (ejeX, ejeY) switch
{
    (0, 0) => "Origen",
    (0, _) or (_, 0) => "Sobre un eje",
    ( > 0, > 0) => "Primer cuadrante",
    ( < 0, > 0) => "Segundo cuadrante",
    ( < 0, < 0) => "Tercer cuadrante",
    ( > 0, < 0) => "Cuarto cuadrante"
};

Console.WriteLine(ubicacion);