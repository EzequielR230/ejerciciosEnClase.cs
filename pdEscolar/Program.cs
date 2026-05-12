int[] A = { 1, 2, 3, 4, 5 };
int[] B = { 5, 4, 3, 2, 1 };
int productoEscalar = 0;

for (int i = 0; i < A.Length; i++)
{
    productoEscalar += A[i] * B[i];
}

Console.WriteLine(productoEscalar);
