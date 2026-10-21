// ### Problema 23. Inicio de sesión

// Un sistema valida el acceso en dos pasos. Primero verifica que el usuario exista (el único usuario registrado es “aprendiz”). 
// Si no existe, muestra `Usuario no encontrado`. Si existe, verifica la contraseña (“Sena2026”): s
// i es correcta muestra `Bienvenido`; si no, 
// muestra `Contraseña incorrecta`. Cada error debe tener su propio mensaje.

Console.WriteLine("Ingrese el usuario:");
string usuario = Console.ReadLine()!.Trim();

if (usuario == "aprendiz")
{
    Console.WriteLine("Ingrese la contraseña:");
    string contrasena = Console.ReadLine()!.Trim();

    if (contrasena == "Sena2026")
    {
        Console.WriteLine("Bienvenido");
    }
    else
    {
        Console.WriteLine("Contraseña incorrecta");
    }
}
else
{
    Console.WriteLine("Usuario no encontrado");
}