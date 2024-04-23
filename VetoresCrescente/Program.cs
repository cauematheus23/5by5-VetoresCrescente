int[] vetor = new int[5];
int[] vetor2 = new int[5];
int aux = 0;
for (int i = 0; i < 5;i++)
{
    vetor[i] = new Random().Next(0,100);
}
for (int i = 0;i < 5; i++)
{
    vetor2[i] = vetor[i];
}    
for (int i = 0; i < 5; i++)
{
    for (int j = i + 1; j < 5; j++)
    {
        if (vetor2[i] > vetor2[j])
        {
            aux = vetor2[i];
            vetor2[i] = vetor2[j];
            vetor2[j] = aux;

        }
    }
}
for (int i = 0; i < 5; i++)
{
    Console.Write(vetor[i] + " ");
}
Console.WriteLine();
for (int i = 0; i < 5; i++)
{
   
    Console.Write(vetor2[i] + " ");
}
