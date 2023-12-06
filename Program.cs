//using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a quantidade mínima em estoque: ");
        int quantidadeMinima = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite a quantidade máxima em estoque: ");
        int quantidadeMaxima = Convert.ToInt32(Console.ReadLine());

        double estoqueMedio = CalcularEstoqueMedio(quantidadeMinima, quantidadeMaxima);

        Console.WriteLine($"O estoque médio é: {estoqueMedio}");

        Console.ReadLine();
    }

    static double CalcularEstoqueMedio(int quantidadeMinima, int quantidadeMaxima)
    {
        return (quantidadeMinima + quantidadeMaxima) / 2.0;
    }
}//

//using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe a cotação do dólar: ");
        double cotacaoDolar = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe o valor em dólares: ");
        double valorDolar = Convert.ToDouble(Console.ReadLine());

        double valorReal = valorDolar * cotacaoDolar;

        Console.WriteLine($"O valor em reais é: {valorReal:C2}");
    }
}//

using System;

//class Program
{
    static void Main()
    {
        Console.Write("Digite a identificação do vendedor: ");
        string identificacaoVendedor = Console.ReadLine();

        Console.Write("Digite o código da peça: ");
        string codigoPeca = Console.ReadLine();

        Console.Write("Digite o preço unitário da peça: ");
        double precoUnitario = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a quantidade vendida: ");
        int quantidadeVendida = Convert.ToInt32(Console.ReadLine());

        double totalVenda = precoUnitario * quantidadeVendida;

        double comissao = totalVenda * 0.05;

        Console.WriteLine("\nDetalhes da venda:");
        Console.WriteLine("Identificação do vendedor: " + identificacaoVendedor);
        Console.WriteLine("Código da peça: " + codigoPeca);
        Console.WriteLine("Preço unitário da peça: " + precoUnitario.ToString("C"));
        Console.WriteLine("Quantidade vendida: " + quantidadeVendida);
        Console.WriteLine("Total da venda: " + totalVenda.ToString("C"));
        Console.WriteLine("Comissão do vendedor (5%): " + comissao.ToString("C"));

        Console.ReadLine();
    }
}//

//using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Informe quatro valores inteiros:");
        Console.Write("Valor A: ");
        int A = int.Parse(Console.ReadLine());

        Console.Write("Valor B: ");
        int B = int.Parse(Console.ReadLine());

        Console.Write("Valor C: ");
        int C = int.Parse(Console.ReadLine());

        Console.Write("Valor D: ");
        int D = int.Parse(Console.ReadLine());

        Console.WriteLine("Resultados das Adições:");
        Console.WriteLine($"A + B = {A + B}");
        Console.WriteLine($"A + C = {A + C}");
        Console.WriteLine($"A + D = {A + D}");
        Console.WriteLine($"B + C = {B + C}");
        Console.WriteLine($"B + D = {B + D}");
        Console.WriteLine($"C + D = {C + D}");

        Console.WriteLine("\nResultados das Multiplicações:");
        Console.WriteLine($"A * B = {A * B}");
        Console.WriteLine($"A * C = {A * C}");
        Console.WriteLine($"A * D = {A * D}");
        Console.WriteLine($"B * C = {B * C}");
        Console.WriteLine($"B * D = {B * D}");
        Console.WriteLine($"C * D = {C * D}");
    }
}//

//using System;

//class Program
{
    static void Main()
    {
        Console.Write("Informe o tempo gasto na viagem (em horas): ");
        double tempo = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe a velocidade média durante a viagem (em km/h): ");
        double velocidadeMedia = Convert.ToDouble(Console.ReadLine());

        double distancia = tempo * velocidadeMedia;

        double litrosUsados = distancia / 12;

        Console.WriteLine("\nResumo da Viagem:");
        Console.WriteLine($"- Velocidade Média: {velocidadeMedia} km/h");
        Console.WriteLine($"- Tempo Gasto: {tempo} horas");
        Console.WriteLine($"- Distância Percorrida: {distancia} km");
        Console.WriteLine($"- Quantidade de Litros Usados: {litrosUsados} litros");
    }
}//

//using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a temperatura em graus Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        double fahrenheit = (9 * celsius + 160) / 5;

        Console.WriteLine($"A temperatura em graus Fahrenheit é: {fahrenheit:F2}");
    }
}//

//using System;

//class Program
{
    static void Main()
    {
        Console.Write("Digite a temperatura em graus Fahrenheit: ");

        double temperaturaFahrenheit = Convert.ToDouble(Console.ReadLine());

        double temperaturaCelsius = (temperaturaFahrenheit - 32) * 5 / 9;

        Console.WriteLine($"A temperatura em graus Celsius é: {temperaturaCelsius:F2} °C");
    }
}//

using System;

//class Program
{
    static void Main()
    {
        Console.Write("Digite o raio da lata de óleo em centímetros: ");
        double raio = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a altura da lata de óleo em centímetros: ");
        double altura = Convert.ToDouble(Console.ReadLine());

        double volume = CalcularVolume(raio, altura);

        Console.WriteLine($"O volume da lata de óleo é: {volume} centímetros cúbicos");
    }

    static double CalcularVolume(double raio, double altura)
    {
        double volume = Math.PI * Math.Pow(raio, 2) * altura;
        return volume;
    }
}//

//using System;

//class Program
{
    static void Main()
    {
        Console.Write("Digite a idade em anos: ");
        int anos = int.Parse(Console.ReadLine());

        Console.Write("Digite a idade em meses: ");
        int meses = int.Parse(Console.ReadLine());

        Console.Write("Digite a idade em dias: ");
        int dias = int.Parse(Console.ReadLine());

        int idadeEmDias = CalcularIdadeEmDias(anos, meses, dias);

        Console.WriteLine($"A idade expressa em dias é: {idadeEmDias} dias");
    }

    static int CalcularIdadeEmDias(int anos, int meses, int dias)
    {
        int idadeEmDias = (anos * 365) + (meses * 30) + dias;
        return idadeEmDias;
    }
}//

using System;

//class Program
{
    static void Main()
    {
        Console.Write("Digite o primeiro número inteiro: ");
        int numero1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número inteiro: ");
        int numero2 = int.Parse(Console.ReadLine());

        if (numero1 == numero2)
        {
            Console.WriteLine("Os números são iguais.");
        }
        else
        {
            Console.WriteLine("Os números são diferentes.");

            if (numero1 > numero2)
            {
                Console.WriteLine($"{numero1} é maior que {numero2}.");
                Console.WriteLine($"{numero2} é menor que {numero1}.");
            }
            else
            {
                Console.WriteLine($"{numero1} é menor que {numero2}.");
                Console.WriteLine($"{numero2} é maior que {numero1}.");
            }
        }

        if (numero1 >= numero2)
        {
            Console.WriteLine($"{numero1} é maior ou igual a {numero2}.");
        }

        if (numero1 <= numero2)
        {
            Console.WriteLine($"{numero1} é menor ou igual a {numero2}.");
        }
    }
}//

//using System;

//class Program
{
    static void Main()
    {
        Console.Write("Digite o valor de A: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor de B: ");
        int b = int.Parse(Console.ReadLine());

        int temp = a;
        a = b;
        b = temp;

        Console.WriteLine("\nValores trocados:");
        Console.WriteLine("A: " + a);
        Console.WriteLine("B: " + b);
    }
}//

//using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número inteiro: ");

        string input = Console.ReadLine();
        int numero;

        if (int.TryParse(input, out numero))
        {
            int modulo = (numero < 0) ? numero * (-1) : numero;
            Console.WriteLine($"O módulo do número {numero} é: {modulo}");
        }
        else
        {
            Console.WriteLine("Por favor, insira um número inteiro válido.");
        }
    }
}//

//using System;

//class Program
{
    static void Main()
    {
        Console.Write("Digite um número inteiro: ");

        string input = Console.ReadLine();
        int numero;

        if (int.TryParse(input, out numero))
        {
            int modulo = (numero < 0) ? numero * (-1) : numero;
            Console.WriteLine($"O módulo do número {numero} é: {modulo}");
        }
        else
        {
            Console.WriteLine("Por favor, insira um número inteiro válido.");
        }
    }
}//

using System;

//class Program
{
    static void Main()
    {
        Console.Write("Digite o primeiro número: ");
        int numero1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        int numero2 = int.Parse(Console.ReadLine());

        Console.Write("Digite o terceiro número: ");
        int numero3 = int.Parse(Console.ReadLine());

        if (numero1 < numero2)
            Trocar(ref numero1, ref numero2);
        if (numero2 < numero3)
            Trocar(ref numero2, ref numero3);
        if (numero1 < numero2)
            Trocar(ref numero1, ref numero2);

        Console.WriteLine("\nNúmeros em ordem decrescente: {0}, {1}, {2}", numero1, numero2, numero3);
    }

    static void Trocar(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
}//

//using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o primeiro número: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o segundo número: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        double diferenca = CalcularDiferenca(numero1, numero2);

        Console.WriteLine($"A diferença entre o maior e o menor número é: {diferenca}");
    }

    static double CalcularDiferenca(double num1, double num2)
    {
        double maior = Math.Max(num1, num2);
        double menor = Math.Min(num1, num2);

        double diferenca = maior - menor;

        return diferenca;
    }
}//

//using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite as quatro notas do aluno:");

        double nota1 = LerNota("Nota 1: ");
        double nota2 = LerNota("Nota 2: ");
        double nota3 = LerNota("Nota 3: ");
        double nota4 = LerNota("Nota 4: ");

        double media = (nota1 + nota2 + nota3 + nota4) / 4;

        if (media >= 7)
        {
            Console.WriteLine($"Aluno aprovado! Média: {media}");
        }
        else
        {
            Console.WriteLine($"Aluno em recuperação. Média: {media}");

            double notaRecuperacao = LerNota("Digite a nota de recuperação: ");

            double novaMedia = (media + notaRecuperacao) / 2;

            if (novaMedia >= 7)
            {
                Console.WriteLine($"Aluno aprovado na recuperação! Nova média: {novaMedia}");
            }
            else
            {
                Console.WriteLine($"Aluno não aprovado na recuperação. Nova média: {novaMedia}");
            }
        }
    }

    static double LerNota(string mensagem)
    {
        double nota;
        do
        {
            Console.Write(mensagem);
        } while (!double.TryParse(Console.ReadLine(), out nota) || nota < 0 || nota > 10);

        return nota;
    }
}//

//using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o primeiro número: ");
        int numero1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        int numero2 = int.Parse(Console.ReadLine());

        if (numero1 > numero2)
        {
            Console.WriteLine($"Maior número: {numero1}");
            Console.WriteLine($"Menor número: {numero2}");
        }
        else if (numero2 > numero1)
        {
            Console.WriteLine($"Maior número: {numero2}");
            Console.WriteLine($"Menor número: {numero1}");
        }
        else
        {
            Console.WriteLine("Os dois números são iguais.");
        }
    }
}//

using System;

//class Program
{
    static void Main()
    {
        Console.Write("Digite um número inteiro: ");

        int numero;
        if (int.TryParse(Console.ReadLine(), out numero))
        {
            if (numero >= 0 && numero <= 9)
            {
                Console.WriteLine("Valor válido");
            }
            else
            {
                Console.WriteLine("Valor inválido");
            }
        }
        else
        {
            Console.WriteLine("Por favor, digite um número inteiro válido.");
        }
    }
}//

//using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número (1, 2 ou 3): ");
        int CODIGO = int.Parse(Console.ReadLine());

        switch (CODIGO)
        {
            case 1:
                Console.WriteLine("Um");
                break;
            case 2:
                Console.WriteLine("Dois");
                break;
            case 3:
                Console.WriteLine("Três");
                break;
            default:
                Console.WriteLine("Código inválido");
                break;
        }
    }
}//

//using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite os três lados do triângulo:");

        Console.Write("Lado A: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Lado B: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Lado C: ");
        double c = double.Parse(Console.ReadLine());

        if (EhTriangulo(a, b, c))
        {
            if (a == b && b == c)
            {
                Console.WriteLine("Triângulo Equilátero");
            }
            else if (a == b || a == c || b == c)
            {
                Console.WriteLine("Triângulo Isósceles");
            }
            else
            {
                Console.WriteLine("Triângulo Escaleno");
            }
        }
        else
        {
            Console.WriteLine("Os lados fornecidos não formam um triângulo.");
        }
    }

    static bool EhTriangulo(double a, double b, double c)
    {
        return a + b > c && a + c > b && b + c > a;
    }
}//

//using System;

class Program
{
    static void Main()
    {
        int a, b, c;

        do
        {
            Console.Write("Digite um valor inteiro maior que zero para a: ");
        } while (!int.TryParse(Console.ReadLine(), out a) || a <= 0);

        do
        {
            Console.Write("Digite um valor inteiro maior que zero para b: ");
        } while (!int.TryParse(Console.ReadLine(), out b) || b <= 0);

        do
        {
            Console.Write("Digite um valor inteiro maior que zero para c: ");
        } while (!int.TryParse(Console.ReadLine(), out c) || c <= 0);

        int menor = Math.Min(Math.Min(a, b), c);
        int maior = Math.Max(Math.Max(a, b), c);

        Console.WriteLine($"Menor valor * Maior valor: {menor * maior}");

        Console.WriteLine($"Maior valor / Menor valor: {maior / (double)menor}");
    }
}//

//using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Digite um número inteiro (ou '0' para sair): ");

            string input = Console.ReadLine();

            if (input == "0")
            {
                Console.WriteLine("Programa encerrado. Pressione qualquer tecla para sair.");
                break;
            }

            if (int.TryParse(input, out int numero))
            { 
                if (numero > 0)
                {
                    Console.WriteLine("O número é positivo.");
                }
                else if (numero < 0)
                {
                    Console.WriteLine("O número é negativo.");
                }
                else
                {
                    Console.WriteLine("O número é zero.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro válido.");
            }

            Console.WriteLine(); 
        }
    }
}//

//using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        int a = 0;
        int b = 0;

        if (numero > 0)
        {
            a = numero;
        }
        else if (numero < 0)
        {
            b = numero;
        }

        Console.WriteLine($"Valor de A: {a}");
        Console.WriteLine($"Valor de B: {b}");

        Console.ReadLine(); 
    }
}//

//using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("0 - Sair");

            Console.Write("Opção: ");
            int escolha = Convert.ToInt32(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    RealizarAdicao();
                    break;

                case 2:
                    RealizarSubtracao();
                    break;

                case 3:
                    RealizarMultiplicacao();
                    break;

                case 4:
                    RealizarDivisao();
                    break;

                case 0:

                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    static void RealizarAdicao()
    {
        Console.Write("Digite o primeiro número: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        double resultado = numero1 + numero2;
        Console.WriteLine($"Resultado da adição: {resultado}");
    }

    static void RealizarSubtracao()
    {
        Console.Write("Digite o primeiro número: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        double resultado = numero1 - numero2;
        Console.WriteLine($"Resultado da subtração: {resultado}");
    }

    static void RealizarMultiplicacao()
    {
        Console.Write("Digite o primeiro número: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        double resultado = numero1 * numero2;
        Console.WriteLine($"Resultado da multiplicação: {resultado}");
    }

    static void RealizarDivisao()
    {
        Console.Write("Digite o numerador: ");
        double numerador = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o denominador: ");
        double denominador = Convert.ToDouble(Console.ReadLine());

        if (denominador != 0)
        {
            double resultado = numerador / denominador;
            Console.WriteLine($"Resultado da divisão: {resultado}");
        }
        else
        {
            Console.WriteLine("Erro: Divisão por zero.");
        }
    }
}//

//using System;

class Program
{
    static void Main()
    {
        int numero1, numero2;

        Console.WriteLine("Digite o primeiro número inteiro:");
        while (!int.TryParse(Console.ReadLine(), out numero1))
        {
            Console.WriteLine("Entrada inválida. Digite um número inteiro:");
        }

        Console.WriteLine("Digite o segundo número inteiro:");
        while (!int.TryParse(Console.ReadLine(), out numero2))
        {
            Console.WriteLine("Entrada inválida. Digite um número inteiro:");
        }

        int opcao;
        do
        {
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1 - Verificar se um dos números é múltiplo do outro");
            Console.WriteLine("2 - Verificar se ambos os números são pares");
            Console.WriteLine("3 - Verificar se a média é maior ou igual a 7");
            Console.WriteLine("4 - Sair");

            while (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 1 || opcao > 4)
            {
                Console.WriteLine("Opção inválida. Escolha uma opção válida:");
            }

            switch (opcao)
            {
                case 1:
                    VerificarMultiplo(numero1, numero2);
                    break;
                case 2:
                    VerificarPares(numero1, numero2);
                    break;
                case 3:
                    VerificarMediaMaiorIgualSete(numero1, numero2);
                    break;
                case 4:
                    Console.WriteLine("Programa encerrado.");
                    break;
            }

        } while (opcao != 4);
    }

    static void VerificarMultiplo(int num1, int num2)
    {
        if (num1 % num2 == 0 || num2 % num1 == 0)
            Console.WriteLine("Um dos números é múltiplo do outro.");
        else
            Console.WriteLine("Nenhum dos números é múltiplo do outro.");
    }

    static void VerificarPares(int num1, int num2)
    {
        if (num1 % 2 == 0 && num2 % 2 == 0)
            Console.WriteLine("Ambos os números são pares.");
        else
            Console.WriteLine("Pelo menos um dos números não é par.");
    }

    static void VerificarMediaMaiorIgualSete(int num1, int num2)
    {
        double media = (num1 + num2) / 2.0;

        if (media >= 7)
            Console.WriteLine($"A média dos números é {media}, que é maior ou igual a 7.");
        else
            Console.WriteLine($"A média dos números é {media}, que é menor que 7.");
    }
}//

//using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a altura em metros: ");
        double altura = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o sexo (M para masculino, F para feminino): ");
        char sexo = Console.ReadLine().ToUpper()[0];

        double pesoIdeal;
        if (sexo == 'M')
        {
            pesoIdeal = (72.7 * altura) - 58;
            Console.WriteLine($"O peso ideal para um homem com {altura} metros de altura é: {pesoIdeal:F2} kg");
        }
        else if (sexo == 'F')
        {
            pesoIdeal = (62.1 * altura) - 44.7;
            Console.WriteLine($"O peso ideal para uma mulher com {altura} metros de altura é: {pesoIdeal:F2} kg");
        }
        else
        {
            Console.WriteLine("Sexo inválido. Por favor, digite M para masculino ou F para feminino.");
        }
    }
}//

//using System;

class Program
{
    static void Main()
    {
        for (int i = 100; i >= 1; i--)
        {
            Console.WriteLine(i);
        }
    }
}//

//using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a quantidade de números a serem processados: ");
        int quantidadeNumeros = int.Parse(Console.ReadLine());

        for (int i = 0; i < quantidadeNumeros; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            int numero = int.Parse(Console.ReadLine());

            long fatorial = CalcularFatorial(numero);
            Console.WriteLine($"O fatorial de {numero} é: {fatorial}");
        }
    }

    static long CalcularFatorial(int numero)
    {
        if (numero == 0 || numero == 1)
        {
            return 1;
        }
        else
        {
            long resultado = 1;
            for (int i = 2; i <= numero; i++)
            {
                resultado *= i;
            }
            return resultado;
        }
    }
}//

//using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Números ímpares entre 100 e 200:");

        for (int i = 100; i <= 200; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
            }
        }

        Console.ReadLine();
    }
}//

//using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 2000; i++)
        {
            Console.WriteLine(i);
        }
    }
}
//

//using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um número para ver sua tabuada:");

        int numero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Tabuada do {numero}:");
        for (int i = 1; i <= 10; i++)
        {
            int resultado = numero * i;
            Console.WriteLine($"{numero} x {i} = {resultado}");
        }

        Console.ReadLine();
    }
}//

//using System;

class Program
{
    static void Main()
    {
        int somaPares = 0;
        int somaImpares = 0;

        Console.WriteLine("Digite números positivos (para encerrar, digite um número negativo):");

        while (true)
        {
            Console.Write("Digite um número: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int numero))
            {
                if (numero < 0)
                    break;

                if (numero % 2 == 0)
                {
                    Console.WriteLine($"{numero} é par.");
                    somaPares += numero;
                }
                else
                {
                    Console.WriteLine($"{numero} é ímpar.");
                    somaImpares += numero;
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
            }
        }

        Console.WriteLine($"Soma total dos números pares: {somaPares}");
        Console.WriteLine($"Soma total dos números ímpares: {somaImpares}");
    }
}//

//using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número inteiro positivo, menor que 10 e maior que zero: ");

        int numero = int.Parse(Console.ReadLine());

        if (numero > 0 && numero < 10)
        {
            int somaQuadrados = 0;

            for (int i = numero; i < numero + 20 * 2; i += 2)
            {
                somaQuadrados += i * i;
            }

            Console.WriteLine($"A soma dos quadrados dos 20 primeiros números ímpares a partir de {numero} é: {somaQuadrados}");
        }
        else
        {
            Console.WriteLine("O número informado não atende aos requisitos.");
        }
    }
}//

//using System;

class Program
{
    static void Main()
    {
        int contadorAlunos = 0;
        double totalNotas = 0;

        Console.WriteLine("Digite as notas dos alunos. Digite -1 para encerrar.");

        while (true)
        {
            Console.Write($"Informe a nota do aluno {contadorAlunos + 1} (-1 para encerrar): ");
            string entradaNota = Console.ReadLine();

            if (double.TryParse(entradaNota, out double nota))
            {
                if (nota == -1)
                {
                    break; // Encerrar o loop quando -1 for inserido
                }

                totalNotas += nota;
                contadorAlunos++;
            }
            else
            {
                Console.WriteLine("Por favor, digite uma nota válida.");
            }
        }

        if (contadorAlunos > 0)
        {
            double media = totalNotas / contadorAlunos;
            Console.WriteLine($"A média das notas dos {contadorAlunos} alunos é: {media:F2}");
        }
        else
        {
            Console.WriteLine("Nenhum aluno foi inserido.");
        }
    }
}//

//using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma sequência de números positivos. Digite um número negativo para encerrar.");

        int menor = int.MaxValue;
        int maior = int.MinValue;

        while (true)
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero < 0)
                break;

            if (numero < menor)
                menor = numero;

            if (numero > maior)
                maior = numero;
        }

        if (menor == int.MaxValue || maior == int.MinValue)
        {
            Console.WriteLine("Nenhum número válido foi inserido.");
        }
        else
        {
            Console.WriteLine($"Menor número: {menor}");
            Console.WriteLine($"Maior número: {maior}");
        }
    }
}//

//using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 100; i++)
        {
            Console.WriteLine(i);

            if (i % 10 == 0)
            {
                Console.WriteLine("Múltiplo de 10");
            }
        }

        Console.ReadLine(); 
    }
}//

//using System;

class Program
{
    static void Main()
    {
        int quantidadeValores = 10;
        int[] valores = new int[quantidadeValores];

        for (int i = 0; i < quantidadeValores; i++)
        {
            Console.Write($"Digite o {i + 1}º valor: ");
            while (!int.TryParse(Console.ReadLine(), out valores[i]) || valores[i] <= 0)
            {
                Console.WriteLine("Por favor, digite um valor inteiro e positivo.");
                Console.Write($"Digite o {i + 1}º valor novamente: ");
            }
        }

        int maiorValor = EncontrarMaiorValor(valores);

        int menorValor = EncontrarMenorValor(valores);

        double media = CalcularMedia(valores);

        Console.WriteLine($"Maior valor: {maiorValor}");
        Console.WriteLine($"Menor valor: {menorValor}");
        Console.WriteLine($"Média dos valores: {media}");
    }

    static int EncontrarMaiorValor(int[] array)
    {
        int maior = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > maior)
            {
                maior = array[i];
            }
        }
        return maior;
    }

    static int EncontrarMenorValor(int[] array)
    {
        int menor = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < menor)
            {
                menor = array[i];
            }
        }
        return menor;
    }

    static double CalcularMedia(int[] array)
    {
        int soma = 0;
        foreach (int valor in array)
        {
            soma += valor;
        }
        return (double)soma / array.Length;
    }
}
//

//using System;

class Program
{
    static void Main()
    {
        bool continuar = true;

        do
        {
            MostrarMenu();
            int opcao = LerOpcao();

            switch (opcao)
            {
                case 1:
                    RealizarOperacao(Adicao);
                    break;
                case 2:
                    RealizarOperacao(Subtracao);
                    break;
                case 3:
                    RealizarOperacao(Multiplicacao);
                    break;
                case 4:
                    RealizarOperacao(Divisao);
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

            Console.Write("Deseja voltar ao menu principal? (S/N): ");
            char resposta = Console.ReadKey().KeyChar;
            continuar = (resposta == 'S' || resposta == 's');
            Console.WriteLine();
        } while (continuar);
    }

    static void MostrarMenu()
    {
        Console.WriteLine("Escolha a operação:");
        Console.WriteLine("1 - Adição");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");
    }

    static int LerOpcao()
    {
        Console.Write("Informe a opção: ");
        return int.Parse(Console.ReadLine());
    }

    static void RealizarOperacao(Func<double, double, double> operacao)
    {
        double numero1, numero2;

        Console.Write("Digite o primeiro número: ");
        numero1 = double.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        numero2 = double.Parse(Console.ReadLine());

        double resultado = operacao(numero1, numero2);
        Console.WriteLine($"Resultado: {resultado}");
    }

    static double Adicao(double a, double b) => a + b;
    static double Subtracao(double a, double b) => a - b;
    static double Multiplicacao(double a, double b) => a * b;

    static double Divisao(double a, double b)
    {
        if (b != 0)
        {
            return a / b;
        }
        else
        {
            Console.WriteLine("Erro: Divisão por zero.");
            return double.NaN;
        }
    }
}//

//using System;

class Program
{
    static void Main()
    {
        char continuar;

        do
        {
            Console.Write("Informe o código do operário: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.Write("Informe o número de horas trabalhadas: ");
            int horasTrabalhadas = int.Parse(Console.ReadLine());

            double salarioTotal = CalcularSalario(codigo, horasTrabalhadas, out double salarioExcedente);

            Console.WriteLine($"Salário total: R$ {salarioTotal:F2}");
            Console.WriteLine($"Salário excedente: R$ {salarioExcedente:F2}");

            Console.Write("Deseja encerrar o programa? (S/N): ");
            continuar = char.ToUpper(Console.ReadKey().KeyChar);

            Console.WriteLine(); 

        } while (continuar != 'S');
    }

    static double CalcularSalario(int codigo, int horasTrabalhadas, out double salarioExcedente)
    {
        const double valorHoraNormal = 10.00;
        const double valorHoraExcedente = 20.00;
        const int horasLimite = 50;

        double salarioTotal = 0;
        salarioExcedente = 0;

        if (horasTrabalhadas > horasLimite)
        {
            int horasNormais = horasLimite;
            int horasExtras = horasTrabalhadas - horasLimite;

            salarioTotal = (horasNormais * valorHoraNormal) + (horasExtras * valorHoraExcedente);
            salarioExcedente = horasExtras * (valorHoraExcedente - valorHoraNormal);
        }
        else
        {
            salarioTotal = horasTrabalhadas * valorHoraNormal;
        }

        return salarioTotal;
    }
}//

//using System;

class Program
{
    static void Main()
    {
        char encerrar = 'N';

        do
        {
            Console.Write("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("O número é par.");
            }
            else
            {
                Console.WriteLine("O número é ímpar.");
            }

            if (numero > 0)
            {
                Console.WriteLine("O número é positivo.");
            }
            else if (numero < 0)
            {
                Console.WriteLine("O número é negativo.");
            }
            else
            {
                Console.WriteLine("O número é zero.");
            }

            Console.Write("Deseja encerrar o programa? (S/N): ");
            encerrar = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine(); 

        } while (encerrar != 'S');
    }
}//

//using System;

class Program
{
    static void Main()
    {
        char encerrarPrograma;

        do
        {
            Console.Write("Informe o índice de poluição medido: ");
            double indicePoluicao = Convert.ToDouble(Console.ReadLine());

            if (indicePoluicao >= 0.3 && indicePoluicao < 0.4)
            {
                Console.WriteLine("Indústrias do 1o grupo devem suspender suas atividades.");
            }
            else if (indicePoluicao >= 0.4 && indicePoluicao < 0.5)
            {
                Console.WriteLine("Indústrias do 1o e 2o grupos devem suspender suas atividades.");
            }
            else if (indicePoluicao >= 0.5)
            {
                Console.WriteLine("Todos os grupos devem paralisar suas atividades.");
            }
            else
            {
                Console.WriteLine("Índice de poluição dentro dos limites aceitáveis.");
            }

            Console.Write("Deseja encerrar o programa? (S/N): ");
            encerrarPrograma = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine(); 

        } while (encerrarPrograma != 'S');
    }
}//

//using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a idade do nadador:");
        int idade;

        if (int.TryParse(Console.ReadLine(), out idade))
        {
            string categoria = ClassificarNadador(idade);
            Console.WriteLine($"O nadador está na categoria: {categoria}");
        }
        else
        {
            Console.WriteLine("Por favor, insira uma idade válida.");
        }
    }

    static string ClassificarNadador(int idade)
    {
        string categoria = "";

        if (idade >= 5 && idade <= 7)
        {
            categoria = "Infantil A";
        }
        else if (idade >= 8 && idade <= 11)
        {
            categoria = "Infantil B";
        }
        else if (idade >= 12 && idade <= 13)
        {
            categoria = "Juvenil A";
        }
        else if (idade >= 14 && idade <= 17)
        {
            categoria = "Juvenil B";
        }
        else if (idade >= 18)
        {
            categoria = "Adulto";
        }

        return categoria;
    }
}//

//using System;

class Program
{
    static void Main()
    {
        int numero;
        int maior = int.MinValue; // Inicializado com o menor valor possível
        int menor = int.MaxValue; // Inicializado com o maior valor possível

        do
        {
            Console.Write("Digite um número (0 para sair): ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero != 0)
            {
                if (numero > maior)
                {
                    maior = numero;
                }

                if (numero < menor)
                {
                    menor = numero;
                }
            }

        } while (numero != 0);

        if (maior != int.MinValue && menor != int.MaxValue)
        {
            Console.WriteLine($"O maior número é: {maior}");
            Console.WriteLine($"O menor número é: {menor}");
        }
        else
        {
            Console.WriteLine("Nenhum número foi inserido.");
        }
    }
}//

//using System;

class Program
{
    static void Main()
    {
        int totalQuadros = 64; 
        ulong totalGraos = CalcularTotalGraos(totalQuadros);

        Console.WriteLine($"O monge esperava receber um total de {totalGraos} grãos de trigo.");
    }

    static ulong CalcularTotalGraos(int totalQuadros)
    {
        ulong totalGraos = 1;
        ulong graosQuadroAtual = 1;

        for (int quadro = 2; quadro <= totalQuadros; quadro++)
        {
            graosQuadroAtual *= 2;
            totalGraos += graosQuadroAtual;
        }

        return totalGraos;
    }
}//

//using System;

class Program
{
    static void Main()
    {
        char opcao;

        do
        {
            ExibirMenu();
            opcao = Console.ReadKey().KeyChar;

            switch (opcao)
            {
                case '1':
                    ConverterCelsiusParaFahrenheit();
                    break;

                case '2':
                    ConverterFahrenheitParaCelsius();
                    break;

                case '3':
                    CalcularPesoIdealHomem();
                    break;

                case '4':
                    CalcularPesoIdealMulher();
                    break;

                case 's':
                case 'S':
                    Console.WriteLine("\nPrograma encerrado.");
                    break;

                default:
                    Console.WriteLine("\nOpção inválida. Tente novamente.");
                    break;
            }

            if (opcao != 's' && opcao != 'S')
            {
                Console.WriteLine("\nDeseja encerrar o programa? (S/N)");
                opcao = Console.ReadKey().KeyChar;
            }

        } while (opcao != 's' && opcao != 'S');
    }

    static void ExibirMenu()
    {
        Console.WriteLine("\nEscolha uma opção:");
        Console.WriteLine("1 - Conversão de Graus Celsius em Graus Fahrenheit");
        Console.WriteLine("2 - Conversão de Graus Fahrenheit em Graus Celsius");
        Console.WriteLine("3 - Peso ideal do homem");
        Console.WriteLine("4 - Peso ideal da mulher");
        Console.WriteLine("S - Encerrar o programa");
    }

    static void ConverterCelsiusParaFahrenheit()
    {
        Console.Write("\nDigite a temperatura em Graus Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());
        double fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine($"A temperatura em Fahrenheit é: {fahrenheit} °F");
    }

    static void ConverterFahrenheitParaCelsius()
    {
        Console.Write("\nDigite a temperatura em Graus Fahrenheit: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());
        double celsius = (fahrenheit - 32) * 5 / 9;
        Console.WriteLine($"A temperatura em Celsius é: {celsius} °C");
    }

    static void CalcularPesoIdealHomem()
    {
        Console.Write("\nDigite a altura em metros: ");
        double altura = Convert.ToDouble(Console.ReadLine());
        double pesoIdeal = (72.7 * altura) - 58;

        Console.Write("Digite o peso atual em kg: ");
        double pesoAtual = Convert.ToDouble(Console.ReadLine());

        if (pesoAtual < pesoIdeal)
        {
            Console.WriteLine("Você está abaixo do peso ideal.");
        }
        else if (pesoAtual > pesoIdeal)
        {
            Console.WriteLine("Você está acima do peso ideal.");
        }
        else
        {
            Console.WriteLine("Você está no peso ideal.");
        }
    }

    static void CalcularPesoIdealMulher()
    {
        Console.Write("\nDigite a altura em metros: ");
        double altura = Convert.ToDouble(Console.ReadLine());
        double pesoIdeal = (62.1 * altura) - 44.7;

        Console.Write("Digite o peso atual em kg: ");
        double pesoAtual = Convert.ToDouble(Console.ReadLine());

        if (pesoAtual < pesoIdeal)
        {
            Console.WriteLine("Você está abaixo do peso ideal.");
        }
        else if (pesoAtual > pesoIdeal)
        {
            Console.WriteLine("Você está acima do peso ideal.");
        }
        else
        {
            Console.WriteLine("Você está no peso ideal.");
        }
    }
}//

//using System;

class Program
{
    static void Main()
    {
        int[] numeros = { 1, 2, 3, 4, 5 };

        for (int i = numeros.Length - 1; i >= 0; i--)
        {
            Console.Write(numeros[i] + " ");
        }
    }
}//

//using System;

class Program
{
    static void Main()
    {
        double[] x = { 1.0, 2.0, 3.0 };
        double[] y = { 4.0, 5.0, 6.0 };

        if (x.Length != y.Length)
        {
            Console.WriteLine("Os vetores têm tamanhos diferentes. Não é possível calcular o produto escalar.");
            return;
        }

        double produtoEscalar = CalcularProdutoEscalar(x, y);

        Console.WriteLine($"O produto escalar dos vetores é: {produtoEscalar}");
    }

    static double CalcularProdutoEscalar(double[] vetorX, double[] vetorY)
    {
        if (vetorX.Length != vetorY.Length)
        {
            throw new ArgumentException("Os vetores têm tamanhos diferentes.");
        }

        double somaProdutos = 0;

        for (int i = 0; i < vetorX.Length; i++)
        {
            somaProdutos += vetorX[i] * vetorY[i];
        }

        return somaProdutos;
    }
}//

//using System;

class Program
{
    static void Main()
    {
        int[] vetor = new int[10];
        Console.WriteLine("Digite 10 números inteiros positivos maiores que zero:");

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"Número {i + 1}: ");
            while (!int.TryParse(Console.ReadLine(), out vetor[i]) || vetor[i] <= 0)
            {
                Console.WriteLine("Por favor, digite um número inteiro positivo maior que zero.");
            }
        }

        int x;
        Console.Write("Digite um número inteiro positivo maior que zero (X): ");
        while (!int.TryParse(Console.ReadLine(), out x) || x <= 0)
        {
            Console.WriteLine("Por favor, digite um número inteiro positivo maior que zero para X.");
        }

        int maioresQueX = 0, menoresQueX = 0, iguaisAX = 0;

        foreach (int numero in vetor)
        {
            if (numero > x)
            {
                maioresQueX++;
            }
            else if (numero < x)
            {
                menoresQueX++;
            }
            else
            {
                iguaisAX++;
            }
        }

        Console.WriteLine($"\nResultados:");
        Console.WriteLine($"Números maiores que X ({x}): {maioresQueX}");
        Console.WriteLine($"Números menores que X ({x}): {menoresQueX}");
        Console.WriteLine($"Números iguais a X ({x}): {iguaisAX}");
    }
}//

//using System;

class Program
{
    static void Main()
    {
        int tamanho = 20;

        string[] nomes = new string[tamanho];

        int[] idades = new int[tamanho];

        PreencherDadosExemplo(nomes, idades);

        ImprimirCandidatasAptas(nomes, idades);

        Console.ReadLine();
    }

    static void PreencherDadosExemplo(string[] nomes, int[] idades)
    {
        for (int i = 0; i < nomes.Length; i++)
        {
            Console.Write($"Informe o nome da candidata {i + 1}: ");
            nomes[i] = Console.ReadLine();

            Console.Write($"Informe a idade da candidata {i + 1}: ");
            idades[i] = Convert.ToInt32(Console.ReadLine());
        }
    }

    static void ImprimirCandidatasAptas(string[] nomes, int[] idades)
    {
        Console.WriteLine("\nCandidatas aptas para a campanha:");

        for (int i = 0; i < nomes.Length; i++)
        {
            if (idades[i] >= 18 && idades[i] <= 20)
            {
                Console.WriteLine($"Nome: {nomes[i]}, Idade: {idades[i]} anos");
            }
        }
    }
}//

//using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o tamanho dos vetores (até 50): ");
        int n = int.Parse(Console.ReadLine());

        if (n <= 0 || n > 50)
        {
            Console.WriteLine("Tamanho inválido. Digite um valor entre 1 e 50.");
            return;
        }

        int[] v1 = new int[n];
        int[] v2 = new int[n];

        Console.WriteLine("Digite os elementos do vetor V1:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"V1[{i}] = ");
            v1[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Digite os elementos do vetor V2:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"V2[{i}] = ");
            v2[i] = int.Parse(Console.ReadLine());
        }

        int cont = 0;
        for (int i = 0; i < n; i++)
        {
            if (v1[i] == v2[i])
            {
                cont++;
            }
        }

        Console.WriteLine($"Quantidade de valores idênticos nas mesmas posições: {cont}");
    }
}
//

//using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int numeroSorteado = random.Next(0, 101);

        int tentativas = 0;
        int tentativaUsuario;

        Console.WriteLine("Tente adivinhar o número sorteado entre 0 e 100:");

        do
        {
            Console.Write("Digite sua tentativa: ");
            if (int.TryParse(Console.ReadLine(), out tentativaUsuario))
            {
                tentativas++;

                if (tentativaUsuario == numeroSorteado)
                {
                    Console.WriteLine($"Parabéns! Você acertou o número {numeroSorteado} em {tentativas} tentativas.");
                }
                else if (tentativaUsuario < numeroSorteado)
                {
                    Console.WriteLine("O número sorteado é maior. Tente novamente.");
                }
                else
                {
                    Console.WriteLine("O número sorteado é menor. Tente novamente.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, insira um número válido.");
            }

        } while (tentativaUsuario != numeroSorteado);

        Console.ReadLine();
    }
}//

//using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a quantidade de alunos (N): ");
        int quantidadeAlunos = int.Parse(Console.ReadLine());

        double somaNotas = 0;
        int alunosAcimaDeSete = 0;

        for (int i = 1; i <= quantidadeAlunos; i++)
        {
            Console.Write($"Digite a nota do aluno {i}: ");
            double nota = double.Parse(Console.ReadLine());

            somaNotas += nota;

            if (nota > 7.0)
            {
                alunosAcimaDeSete++;
            }
        }

        if (alunosAcimaDeSete > 0)
        {
            double media = somaNotas / quantidadeAlunos;

            Console.WriteLine($"Média aritmética das notas: {media:F2}");
            Console.WriteLine($"Número de alunos com nota acima de 7.0: {alunosAcimaDeSete}");
        }
        else
        {
            Console.WriteLine("Não há nenhum aluno com nota acima de 7.0.");
        }
    }
}//

//using System;

class Program
{
    static void Main()
    {
        const int tamanhoMaximo = 100;
        int[] vetor = new int[tamanhoMaximo];

        Console.WriteLine("Digite os números inteiros e positivos (use -1 para encerrar):");

        int indice = 0;
        int numero;
        do
        {
            Console.Write($"Posição {indice + 1}: ");
            if (int.TryParse(Console.ReadLine(), out numero))
            {
                if (numero == -1)
                {
                    break;
                }

                vetor[indice] = numero;
                indice++;
            }
            else
            {
                Console.WriteLine("Por favor, digite um número inteiro válido.");
            }

        } while (indice < tamanhoMaximo);

        int contagem1 = 0, contagem3 = 0, contagem4 = 0;
        for (int i = 0; i < indice; i++)
        {
            if (vetor[i] == 1)
            {
                contagem1++;
            }
            else if (vetor[i] == 3)
            {
                contagem3++;
            }
            else if (vetor[i] == 4)
            {
                contagem4++;
            }
        }

        Console.WriteLine($"Número de ocorrências de 1: {contagem1}");
        Console.WriteLine($"Número de ocorrências de 3: {contagem3}");
        Console.WriteLine($"Número de ocorrências de 4: {contagem4}");

        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}//

//using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Informe o número de voltas:");
        int n = int.Parse(Console.ReadLine());

        double[] tempos = new double[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Informe o tempo da volta {i + 1} em segundos:");
            tempos[i] = double.Parse(Console.ReadLine());
        }

        double melhorTempo = double.MaxValue;
        int voltaMelhorTempo = -1;

        for (int i = 0; i < n; i++)
        {
            if (tempos[i] < melhorTempo)
            {
                melhorTempo = tempos[i];
                voltaMelhorTempo = i + 1;
            }
        }

        double tempoMedio = 0;
        for (int i = 0; i < n; i++)
        {
            tempoMedio += tempos[i];
        }
        tempoMedio /= n;

        Console.WriteLine($"Melhor tempo: {melhorTempo} segundos");
        Console.WriteLine($"Volta do melhor tempo: {voltaMelhorTempo}");
        Console.WriteLine($"Tempo médio das {n} voltas: {tempoMedio} segundos");
    }
}//

//using System;

class Program
{
    static void Main()
    {
        int[] A = { 1, 2, 3, 4, 5 };
        int[] B = { 3, 4, 5, 6, 7, 8, 9, 10 };

        // Imprima os elementos comuns
        Console.WriteLine("Elementos comuns aos dois vetores:");
        EncontrarElementosComuns(A, B);

        Console.ReadKey();
    }

    static void EncontrarElementosComuns(int[] vetorA, int[] vetorB)
    {
 
        foreach (int elementoA in vetorA)
        {
            if (Array.Exists(vetorB, elementoB => elementoB == elementoA))
            {
                Console.WriteLine(elementoA);
            }
        }
    }
}//

//using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma frase de até 50 caracteres:");
        string frase = Console.ReadLine();

        if (frase.Length > 50)
        {
            Console.WriteLine("A frase deve ter no máximo 50 caracteres.");
            return;
        }

        string fraseSemEspacos = RemoverEspacos(frase);

        Console.WriteLine($"Frase sem espaços em branco: {fraseSemEspacos}");

        int quantidadeEspacos = ContarEspacos(frase);
        Console.WriteLine($"Quantidade de espaços em branco: {quantidadeEspacos}");
    }

    static string RemoverEspacos(string frase)
    {
        return frase.Replace(" ", "");
    }

    static int ContarEspacos(string frase)
    {
        int count = 0;
        foreach (char c in frase)
        {
            if (c == ' ')
            {
                count++;
            }
        }
        return count;
    }
}//

//using System;

class Program
{
    static void Main()
    {
        int tamanhoVetor = 50;

        int[] vetor = new int[tamanhoVetor];

        PreencherVetor(vetor);

        int quantidadePares = ContarPares(vetor);
        Console.WriteLine($"Quantidade de números pares: {quantidadePares}");

        int quantidadeMultiplosDe5 = ContarMultiplosDe5(vetor);
        Console.WriteLine($"Quantidade de múltiplos de 5: {quantidadeMultiplosDe5}");
    }

    static void PreencherVetor(int[] vetor)
    {
        Console.WriteLine("Digite os valores do vetor:");

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"Vetor[{i}]: ");
            if (int.TryParse(Console.ReadLine(), out int valor))
            {
                vetor[i] = valor;
            }
            else
            {
                Console.WriteLine("Valor inválido. Digite novamente.");
                i--;
            }
        }
    }

    static int ContarPares(int[] vetor)
    {
        int quantidadePares = 0;

        foreach (int numero in vetor)
        {
            if (numero % 2 == 0)
            {
                quantidadePares++;
            }
        }

        return quantidadePares;
    }

    static int ContarMultiplosDe5(int[] vetor)
    {
        int quantidadeMultiplosDe5 = 0;

        foreach (int numero in vetor)
        {
            if (numero % 5 == 0)
            {
                quantidadeMultiplosDe5++;
            }
        }

        return quantidadeMultiplosDe5;
    }
}//

//using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma frase:");
        string frase = Console.ReadLine();

        string vogais = ExtrairVogais(frase);

        Console.WriteLine("Vogais na frase: " + vogais);
    }

    static string ExtrairVogais(string input)
    {
        string vogais = "";
        foreach (char letra in input)
        {
            if (IsVogal(letra))
            {
                vogais += letra;
            }
        }
        return vogais;
    }

    static bool IsVogal(char letra)
    {
        char[] vogais = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        return Array.IndexOf(vogais, letra) != -1;
    }
}//using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a quantidade de números a serem lidos: ");
        int quantidade = int.Parse(Console.ReadLine());

        if (quantidade <= 0)
        {
            Console.WriteLine("Por favor, insira uma quantidade válida de números.");
            return;
        }

        int[] numeros = new int[quantidade];

        for (int i = 0; i < quantidade; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            numeros[i] = int.Parse(Console.ReadLine());

            if (numeros[i] < 0)
            {
                Console.WriteLine("Por favor, insira apenas números inteiros e positivos.");
                i--; 
            }
        }

        double media = CalcularMedia(numeros);

        int maior = EncontrarMaior(numeros);

        Console.WriteLine($"A média dos números é: {media}");
        Console.WriteLine($"O maior número é: {maior}");
    }

    static double CalcularMedia(int[] numeros)
    {
        int soma = 0;

        foreach (int numero in numeros)
        {
            soma += numero;
        }

        return (double)soma / numeros.Length;
    }

    static int EncontrarMaior(int[] numeros)
    {
        int maior = numeros[0];

        foreach (int numero in numeros)
        {
            if (numero > maior)
            {
                maior = numero;
            }
        }

        return maior;
    }
}//

//using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite dois caracteres de A a Z em ordem alfabética:");

        Console.Write("Digite o primeiro caractere: ");
        char char1 = char.ToUpper(Console.ReadKey().KeyChar);

        Console.WriteLine(); 

        Console.Write("Digite o segundo caractere: ");
        char char2 = char.ToUpper(Console.ReadKey().KeyChar);

        Console.WriteLine();

        if (char1 >= 'A' && char1 <= 'Z' && char2 >= 'A' && char2 <= 'Z' && char1 <= char2)
        {
            int numCaracteres = char2 - char1 - 1;
            Console.WriteLine($"Existem {numCaracteres} caracteres entre '{char1}' e '{char2}'.");
        }
        else
        {
            Console.WriteLine("Erro: Certifique-se de digitar dois caracteres em ordem alfabética.");
        }
    }
}//

//using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o valor de x:");
        double x = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor de y:");
        double y = double.Parse(Console.ReadLine());

        int quadrante = VERIFICA_QUADRANTE(x, y);

        Console.WriteLine($"O ponto ({x}, {y}) está no quadrante {quadrante}.");
    }

    static int VERIFICA_QUADRANTE(double x, double y)
    {
        if (x > 0 && y > 0)
        {
            return 1;
        }
        else if (x < 0 && y > 0)
        {
            return 2;
        }
        else if (x < 0 && y < 0)
        {
            return 3;
        }
        else if (x > 0 && y < 0)
        {
            return 4;
        }
        else
        {

            return 0;
        }
    }
}//

//using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe o salário atual: ");
        double salarioAtual = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe o índice de reajuste (em percentual): ");
        double indiceReajuste = Convert.ToDouble(Console.ReadLine());

        double salarioAtualizado = CalcularSalarioAtualizado(salarioAtual, indiceReajuste);

        Console.WriteLine($"O salário atualizado é: {salarioAtualizado:C}");
    }

    static double CalcularSalarioAtualizado(double salario, double indiceReajuste)
    {
        double fatorReajuste = 1 + (indiceReajuste / 100);

        double salarioAtualizado = salario * fatorReajuste;

        return salarioAtualizado;
    }
}//

//using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o valor da base do triângulo: ");
        double baseTriangulo = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o valor da altura do triângulo: ");
        double alturaTriangulo = Convert.ToDouble(Console.ReadLine());

        double resultado = HIPOTENUSA(baseTriangulo, alturaTriangulo);

        Console.WriteLine($"A hipotenusa do triângulo é: {resultado}");
    }

    static double HIPOTENUSA(double baseTriangulo, double alturaTriangulo)
    {
        double hipotenusa = Math.Sqrt(Math.Pow(baseTriangulo, 2) + Math.Pow(alturaTriangulo, 2));
        return hipotenusa;
    }
}//

//using System;

class Program
{
    static void Main()
    {
        int numero = 7;
        string resultado = VERIFICA(numero);
        Console.WriteLine($"O número {numero} é {resultado}.");
    }

    static string VERIFICA(int n)
    {
        if (n % 2 == 0)
        {
            return "PAR";
        }
        else
        {
            return "ÍMPAR";
        }
    }
}//
