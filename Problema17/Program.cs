// ### Problema 17. Control de un reproductor

// Un reproductor de música recibe comandos de texto: 
// “play”, “pause”, “stop”, “next”. Cada comando imprime un mensaje distinto 
// (`Reproduciendo...`, `En pausa`, `Detenido`, `Siguiente canción`). Un comando desconocido imprime `Comando no reconocido`.


Console.WriteLine("Ingrese un comando (play, pause, stop, next):");
string comando = Console.ReadLine()!.Trim().ToLower();

string mensaje = comando switch
{
    "play" => "Reproduciendo...",
    "pause" => "En pausa",
    "stop" => "Detenido",
    "next" => "Siguiente canción",
    _ => "Comando no reconocido"
};

Console.WriteLine(mensaje);