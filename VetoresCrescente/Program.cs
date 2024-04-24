int size = 10, aux = 0;
int[] vetor = new int[size];
int[] vetor2 = new int[size];

for (int i = 0; i < size;i++)
{
    vetor[i] = new Random().Next(0,100);
    vetor2[i] = vetor[i];
}
for (int i = 0; i < size; i++)
{
    for (int j = i + 1; j < size; j++)
    {
        if (vetor2[i] > vetor2[j])
        {
            aux = vetor2[i];
            vetor2[i] = vetor2[j];
            vetor2[j] = aux;

        }
    }
}
Console.Write("Vetor simples");
Console.WriteLine();
for (int i = 0; i < size; i++)
{
    Console.Write(vetor[i] + " ");
}
Console.WriteLine();
Console.WriteLine("Vetor Ordenado");
for (int i = 0; i < size; i++)
{
   
    Console.Write(vetor2[i] + " ");
}
Console.WriteLine();
Console.WriteLine("Vetor Ordenado sem repetição");
for (int i = 0; i < size;)
{
    aux = vetor2[i];
    Console.Write(aux + " ");

    
    while (i < size && vetor2[i] == aux)
    {
        i++;
    }
}