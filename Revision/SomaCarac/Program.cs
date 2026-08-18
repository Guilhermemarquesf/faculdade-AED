for (int n = 1000; n <= 9999; n++)
{
    int p1 = n / 100;
    int p2 = n % 100;
    int soma = p1 + p2;
    int quadrado = soma * soma;

    if (quadrado == n)
    {
        Console.WriteLine($"O número {n} possui essa característica");
    }
}
Console.ReadKey();