
 double [,] matriz = new double [3,3];
int Cont = 1;
Console.WriteLine("matrices");


try 
{
    Console.WriteLine("ingresa las temperaturas");
    
  
    for (int r = 0; r < 3; r++)
    {
        for (int C = 0; C < 3; C++)
        {
            Console.WriteLine($"dime la temperatura # {Cont++} :");
            // Si el usuario escribe "hola", el código saltará directamente al 'catch'
            matriz[r, C] = Convert.ToDouble(Console.ReadLine());
        }
    }
}
catch (Exception ex)
{
    Console.ForegroundColor= ConsoleColor.Red;
    Console.WriteLine("Error fatal: Debes ingresar solo números.");
    Console.WriteLine("Detalle técnico: " + ex.Message);
}
Console.ResetColor();     

for(int r=0; r< 3 ; r++)
{
    for (int C=0 ; C<3 ; C++) 
    {
        Console.WriteLine($"dime la tempeatura # {Cont ++} :");
        matriz[r , C] = Convert.ToDouble(Console.ReadLine());

    }
}
Console.Clear();
Console.WriteLine("Temeperaturas registradas");
for(int f=0; f< 3 ; f++)
{
    for (int C = 0; C < 3; C++)
    {
        if (matriz[f , C] < 35)Console.ForegroundColor = ConsoleColor.Green;
        else if (matriz [f , C] >=35 && matriz[f , C] < 40) Console.ForegroundColor = ConsoleColor.Yellow;
        else Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($"{matriz[f, C]}\t");
        Console.ResetColor();
    }
    Console.WriteLine();
}