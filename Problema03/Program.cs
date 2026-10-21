// ### Problema 3. Menú de cajero automático

// El cajero muestra un menú: 1 = Consultar saldo, 2 = Retirar, 3 = Depositar, 4 = Salir. 
// Según la opción digitada, el programa imprime la acción. Cualquier otro número muestra `Opción no válida`.

// - Entrada: 2 → `Ha seleccionado: Retirar`
// - Entrada: 9 → `Opción no válida`


Console.WriteLine("1 = Consultar saldo\n2 = Retirar\n3 = Depositar\n4 = Salir");
Console.WriteLine("Ingrese una opcion:");
int opcion = int.Parse(Console.ReadLine()!);

switch (opcion)
{
    case 1:
        Console.WriteLine("Ha seleccionado Consultar saldo");
        break;

    case 2:
        Console.WriteLine("Ha seleccionado Retirar");
        break;

    case 3:
        Console.WriteLine("Ha seleccionado Depositar");
        break;

    case 4:
        Console.WriteLine("Ha seleccionado Salir");
        break;

    default:
        Console.WriteLine("Opcion no valida");
        break;
}