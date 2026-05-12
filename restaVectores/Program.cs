int [] vector1= new int [5];
int [] vector2= new int [5];
int [] resultado= new int [5];

for (int i=0; i<5; i++)
{   
    try
    {   
    Console.WriteLine("ingrese el numero "+(i+1)+" del vector 1");
    vector1[i] = int.Parse(Console.ReadLine());
    }   
    catch (FormatException)
    {   
        Console.ForegroundColor=ConsoleColor.Red;
        Console.WriteLine("Error: Ingrese un número válido para el vector 1.");
        i--;
    }   Console.ResetColor();
    try
    {
    Console.WriteLine("ingrese el numero "+(i+1)+" del vector 2");
    vector2[i] = int.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.ForegroundColor=ConsoleColor.Red;
        Console.WriteLine("Error: Ingrese un número válido para el vector 2.");
        i--;
    }
    Console.ResetColor();

    
}

for (int i=0; i<5; i++)
{
    resultado[i]=vector1[i]-vector2[i];
}
Console.WriteLine("El resultado de la resta de los  vectores es:");
for (int i=0; i<5; i++)
{
    Console.WriteLine(resultado[i]);
}