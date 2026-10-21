// ### Problema 21. Carrito de compras

// La tienda virtual muestra cuántos artículos hay en el carrito. 
// La palabra debe ir en singular si hay exactamente uno y en plural en cualquier otro caso. 
// Construye el mensaje con una sola línea de asignación.

// - 1 → `Tienes 1 artículo en el carrito`
// - 3 → `Tienes 3 artículos en el carrito`
// - 0 → `Tienes 0 artículos en el carrito`

Console.WriteLine("Ingrese la cantidad de artículos en el carrito:");
int cantidad = int.Parse(Console.ReadLine()!.Trim());

string mensaje = $"Tienes {cantidad} artículo{(cantidad == 1 ? "" : "s")} en el carrito";

Console.WriteLine(mensaje);