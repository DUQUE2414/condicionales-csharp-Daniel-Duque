// ### Problema 11. Semáforo inteligente

// Define un tipo con los estados posibles de un semáforo: Rojo, Amarillo y Verde. Según el estado actual, 
// el programa imprime la instruccion para el conductor:

// - Rojo → `Deténgase`
// - Amarillo → `Precaución, prepárese para detenerse`
// - Verde → `Avance`




Console.WriteLine("Ingrese el estado del semaforo (rojo, amarillo, verde)");
string estado = Console.ReadLine()!.Trim().ToLower();


string instruccion = estado switch
{
    "rojo" => "detengase",
    "amarillo" => "Precaución, prepárese para detenerse",
    "verde" => "avance",
    _ => "Opcion invalida"
};

Console.WriteLine(instruccion);
