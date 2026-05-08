using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

int  [] vector= new int [5];
int [] vector2= new int [5];
int [] sumaVector= new int [5];

Console.WriteLine("Ingrese los elementos del primer vector:");
for(int i = 0; i<vector.Length; i++)
{
  try
    {   
        Console.ForegroundColor=ConsoleColor.Red;
        Console.Write($"Elemento {i+1}: ");
        vector[i] = int.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
        i--; // Decrementar el índice para volver a solicitar el mismo elemento 
        Console.ResetColor();
    } 
}

Console.WriteLine( "ingrese los elementos del segundo vector:");
for(int i=0; i<vector2.Length; i++)
{
  try
    {   
        Console.ForegroundColor=ConsoleColor.Red;
        Console.Write($"Elemento {i+1}: ");
        vector2[i] = int.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
        i--; // Decrementar el índice para volver a solicitar el mismo elemento 
        Console.ResetColor();
    } 
}

for(int i=0;i<sumaVector.Length; i++)
{
    sumaVector[i]=vector[i]+vector2[i];
}
Console.ForegroundColor=ConsoleColor.Green;
Console.WriteLine("La suma de los dos vectores es:");   
for(int i=0; i<sumaVector.Length; i++)
{
    Console.WriteLine($"Elemento {i+1}: {sumaVector[i]}");
}