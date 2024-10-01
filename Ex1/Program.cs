//Exemplo de trycatch com numerador e donoiminador O bloco try-catch em C# permite que você execute um bloco de codigo
//(try) que pode gerar execuções. se uma execução ocorrer ela ira ser tratada no catch

/* Exemplo 1 com números inteiros */

//try
//{
//    Console.Write("Digite o númerador: "); // string "5" = 5 int
//    int numerador = int.Parse(Console.ReadLine()); // string "5" = 5 int

//    Console.Write("Digite o denominador: ");
//    int denominador = int.Parse(Console.ReadLine());

//    int divi = numerador / denominador;
//    Console.WriteLine($"O Resultado da divisão é: {divi}");
//}catch(DivideByZeroException)
//{
//    Console.WriteLine("Erro: não é possiveldividir por zero");
//}
//catch(FormatException)
//{
//    Console.WriteLine("Erro: Por favor, digite numeros validos");
//}


/* Exemplo 2 com casas decimais utilizando double e convertendo esses valores como tryParse */
using System.Globalization;

try
{
    Console.Write("Digite o númerador: "); // string "5" = 5 int
    double numerador; // string "5" = 5 int
    while (!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out numerador))
    {
        Console.WriteLine("Erro: por favor digite um numero valido");
        Console.Write("Digite o Numerador:");
    }

    Console.Write("Digite o denominador: ");
    double denominador;
    while (!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out denominador))
    {
        Console.WriteLine("Erro: por favor digite um numero valido");
        Console.Write("Digite o Denominador:");
    }

    //1verifica o valor do denominador e caso seja zero gera uma exeção
    if (denominador == 0)
    {
        throw new DivideByZeroException();
    }

    double divi = numerador / denominador;
    Console.WriteLine($"O Resultado da divisão é: {divi}");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Erro: não é possiveldividir por zero");
}
catch (FormatException)
{
    Console.WriteLine("Erro: Por favor, digite numeros validos");
}
Console.ReadKey();