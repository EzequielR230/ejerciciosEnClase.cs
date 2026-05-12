int[] V = { 3, 4, 5, 6, 7 };
double suma = 0;

for (int i = 0; i < V.Length; i++)
{
    suma += V[i] * V[i];
}

double magnitud = Math.Sqrt(suma);

Console.WriteLine(magnitud);
