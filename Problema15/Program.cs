// ### Problema 15. Índice de masa corporal

// Calcula el IMC con la fórmula peso / (estatura × estatura), peso en kg y estatura en metros, 
// y clasifica el resultado. Se deben mostrar el valor del IMC con un decimal y la categoría:

// - Menos de 18,5: Bajo peso
// - De 18,5 a menos de 25: peso normal
// - De 25 a menos de 30: Sobrepeso
// - 30 o más: Obesidad

// Ejemplo: peso 70, estatura 1,75 → `IMC: 22,9 - peso normal`


Console.WriteLine("Cuanto pesas ( kg )?");
double Peso = double.Parse(Console.ReadLine()!.Trim()); 

Console.WriteLine("Cuanto mides ( m )?");
double Estatura = double.Parse(Console.ReadLine()!.Trim()); 

double IMC = Peso / (Estatura * Estatura);

string Categoria = IMC switch
{
    < 18.5 => "Bajo peso",
    > 18.5 and < 25 => "Normal",
    > 25 and < 30 => "Sobrepeso",
    _ => "Obesidad"
};

Console.WriteLine($"Peso: {Peso} | Estatura: {Estatura} -> IMC: {IMC:F1} - {Categoria}");