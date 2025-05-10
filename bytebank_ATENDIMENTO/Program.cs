Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

// TestaArrrayInt();
//TestaBuscarPalavra();
void TestaArrrayInt ()
{ 
    int[] idades = new int[5];
    idades[0] = 30;
    idades[1] = 40;
    idades[2] = 17;
    idades[3] = 21;
    idades[4] = 18;

    Console.WriteLine($"Tamanho do Array {idades.Length}");

    int acumulador = 0;

    for (int i = 0; i< idades.Length; i++)
    {
        int idade = idades[i];
        Console.WriteLine($"Índice [{i}] = {idade}");
        acumulador += idade;
    }
    int media = acumulador / idades.Length;
    Console.WriteLine($"Média de idades = {media}");
} 

void TestaBuscarPalavra ()
{
    string[] arrayDePalavras = new string[5];

    for (int i = 0; i < arrayDePalavras.Length; i++)
    {
        Console.Write($"Digite {i + 1} Palavra: ");
        arrayDePalavras[i] = Console.ReadLine();
    }

    Console.Write($"Digite palavra a ser encontrada: ");
    var busca = Console.ReadLine();

    foreach (string palavra in arrayDePalavras)
    {
        if (palavra.Equals(busca))
        {
            Console.WriteLine($"Palavra encontrada = {busca}.");
            break;
        }

    }
}

Array amostra = Array.CreateInstance(typeof(double), 5);
amostra.SetValue(5.9, 0);
amostra.SetValue(1.8, 1);
amostra.SetValue(7.1, 2);
amostra.SetValue(10,3);
amostra.SetValue(6.9,4);

TestaMediana(amostra);

void TestaMediana(Array array)
{
    if (array == null || (array.Length==0))
    {
        Console.WriteLine("Array vazio ou nulo.");
    }

    double[] numerosOrdenados = (double [])array.Clone();
    Array.Sort(numerosOrdenados);
    //[1,8][5,9][6,9][7,1][10]

    int tamanho = numerosOrdenados.Length;
    int meio = tamanho / 2;
    double mediana = (tamanho % 2 == 0) ? 
                                    (numerosOrdenados[meio - 1] + numerosOrdenados[meio]) / 2 : numerosOrdenados[meio];
    Console.WriteLine($"A mediana é {mediana}");
}


double CalcularMedia(double[] amostra)
{
    if(amostra == null || amostra.Length == 0)
    {
        throw new ArgumentException("A amostra não pode ser nula ou vazia.");
    }

    double soma = 0;
    foreach(double valor in amostra)
    {
        soma += valor;
    }
    return soma / amostra.Length;
}