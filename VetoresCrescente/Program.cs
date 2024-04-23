int[] vetor = new int[5];
int maior = 0, aux = 0 ;
for (int i = 0; i < 5; i++)
{
    do
    {
        Console.WriteLine($"Digite o {i + 1}° valor: ");
        vetor[i] = int.Parse(Console.ReadLine());
    } while (vetor[i] < 0);
}
for (int i = 0;i < 5; i++)
{
    if (vetor[i] > maior)
    {
        maior = vetor[i];
    }
}