int numero;

while (true)
{
    Console.WriteLine("ingrese un numero entero");
    if (int.TryParse(Console.ReadLine(), out  numero))
    {
        break;
    }
    else
    {
        Console.ForegroundColor=ConsoleColor.Red;
        Console.WriteLine("Entrada no valida, por favor; Ingrese un numero entero.");
        Console.ResetColor();
    }
}

Console.WriteLine("Mostrando el cudrado de los antecesores de " + numero+ ";");
int cont =1;
while( cont < numero)
{
    Console.WriteLine("El cuadrado de" + cont+ "es: " + Math.Pow(cont,2));
    cont ++;
}