int size = 10, aux = 0;
int[] vetor = new int[size];
int[] vetor_ordenado = new int[size];
int[] vetor_desordenado = new int[size];



for (int i = 0; i < size; i++)
{
    vetor[i] = new Random().Next(0, 20);
    vetor_ordenado[i] = vetor[i];
    vetor_desordenado[i] = vetor[i];
}
for (int i = 0; i < size; i++)
{
    for (int j = i + 1; j < size; j++)
    {
        if (vetor_ordenado[i] > vetor_ordenado[j])
        {
            aux = vetor_ordenado[i];
            vetor_ordenado[i] = vetor_ordenado[j];
            vetor_ordenado[j] = aux;

        }
    }
}
for (int i = size -1; i >= 0; i--)
{
    for (int j = i - 1; j >= 0; j--)
    {
        if (vetor_desordenado[i] > vetor_desordenado[j])
        {
            aux  = vetor_desordenado[i];
            vetor_desordenado[i] = vetor_desordenado[j];
            vetor_desordenado[j] = aux;

        }
    }
}
Console.Write("Vetor gerado");
Console.WriteLine();
for (int i = 0; i < size; i++)
{
    Console.Write(vetor[i] + " ");
}
Console.WriteLine();
Console.WriteLine("Vetor Ordenado com repetição");
for (int i = 0; i < size; i++)
{

    Console.Write(vetor_ordenado[i] + " ");
}
Console.WriteLine();
Console.WriteLine("Vetor Ordenado sem repetição");
for (int i = 0; i < size;)
{
    aux = vetor_ordenado[i];
    Console.Write(aux + " ");


    while (i < size && vetor_ordenado[i] == aux)
    {
        i++;
    }
}
Console.WriteLine();
Console.WriteLine("Vetor Decrescente com repetição");
for (int i = 0; i < size; i++)
{

    Console.Write(vetor_desordenado[i] + " ");
}
Console.WriteLine();
Console.WriteLine("Vetor Decrescente sem repetição");
for (int i = 0; i < size;)
{
    aux = vetor_desordenado[i];
    Console.Write(aux + " ");


    while (i < size && vetor_desordenado[i] == aux)
    {
        i++;
    }
}