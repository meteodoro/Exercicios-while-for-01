using System.Globalization;

namespace Exercicios_while_for_01;

internal class Program
{
    private static void Main(string[] args)
    {
        Exercicio8();
    }

    //17. Faça um programa que calcule o fatorial de um número inteiro fornecido pelo usuário. Ex.: 5!=5.4.3.2.1=120
    private static void Exercício17()
    {
        Console.WriteLine("Digite um número inteiro para calcular seu fatorial: ");
        if (int.TryParse(Console.ReadLine(), out var n) && n >= 0)
        {
            long resultado = 1;
            for (var i = 1; i <= n; i++) resultado *= i;
            Console.WriteLine($"O fatorial de {n} é {resultado}.0");
        }
        else
        {
            Console.WriteLine("Por favor, digita um número válido, inteiro, maior ou igual a zero.");
        }
    }
    
    //8. Faça um programa que leia 5 números e informe a soma e a média dos números.
    static void Exercicio8()
    {
        List<int> numeros = new List<int>();
        for (var i = 0; numeros.Count < 5; i++)
        {
            Console.WriteLine($"Digite o {numeros.Count + 1}º número: ");
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                numeros.Add(numero);
            }
            else
            {
                Console.WriteLine("Digite um número válido.");
            }
        }
        int soma = numeros.Sum();
        double media = numeros.Average();
        Console.WriteLine($"A soma dos números da lista informada é: {soma}.");
        Console.WriteLine($"A média dos números da lista informada é: {media}.");
    }
    
    //7. Faça um programa que leia 5 números e informe o maior número.
    static void Exercicio7()
    {
        List<int> numeros = new List<int>();
        for (var i = 0; numeros.Count < 5; i++)
        {
            Console.WriteLine($"Digite o {numeros.Count + 1}º número: ");
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                numeros.Add(numero);
            }
            else
            {
                Console.WriteLine("Digite um número válido.");
            }
        }
        int maiorNumero = numeros.Max();
        Console.WriteLine($"O maior número da lista informada é: {maiorNumero}.");
    }
    
    // 6. Faça um programa que imprima na tela os números de 1 a 20, um abaixo do outro. 
    //    Depois modifique o programa para que ele mostre os números um ao lado do outro.
    static void Exercicio6()
    {
        //Um abaixo do outro
        for (int i = 1; i <= 20; i++)
        {
            Console.WriteLine(i);
        }
        
        //Um ao lado do outro
        for (int i = 1; i <= 20; i++)
        {
            Console.Write($"{i} ");
        }
    }
    
    //5. Altere o programa anterior permitindo ao usuário informar as populações e as taxas de crescimento
    //   iniciais. Valide a entrada e permita repetir a operação.
    private static void Exercicio5()
    {
        while (true)
        {
            double popA = 0;
            double taxaA = 0;
            double popB = 0;
            double taxaB = 0;
            var anos = 0;

            while (true)
            {
                Console.Write("Digite a população inicial do País A: ");
                if (double.TryParse(Console.ReadLine(), out popA) && popA > 0) break;
                Console.WriteLine("A população inicial do país A deve ser um número válido maior que 0.");
                Console.WriteLine("Pressione qualquer tecla para tentar novamente...");
                Console.ReadKey();
                Console.Clear();
            }

            while (true)
            {
                Console.Write("Digite a taxa de crescimento do País A em porcentagem: ");
                if (double.TryParse(Console.ReadLine(), out taxaA) && taxaA > 0) break;
                Console.WriteLine("A taxa de crescimento do país A deve ser um número válido maior que 0.");
                Console.WriteLine("Pressione qualquer tecla para tentar novamente...");
                Console.ReadKey();
                Console.Clear();
            }

            while (true)
            {
                Console.Write("Digite a população inicial do País B: ");
                if (double.TryParse(Console.ReadLine(), out popB) && popB > 0) break;
                Console.WriteLine("A população inicial do país B deve ser um número válido maior que 0.");
                Console.WriteLine("Pressione qualquer tecla para tentar novamente...");
                Console.ReadKey();
                Console.Clear();
            }

            while (true)
            {
                Console.Write("Digite a taxa de crescimento do País B em porcentagem: ");
                if (double.TryParse(Console.ReadLine(), out taxaB) && taxaB > 0) break;
                Console.WriteLine("A taxa de crescimento do país B deve ser um número válido maior que 0.");
                Console.WriteLine("Pressione qualquer tecla para tentar novamente...");
                Console.ReadKey();
                Console.Clear();
            }

            if (popA >= popB) Console.WriteLine("A população doo país A já é maior ou igual à população do país B.");
            else if (taxaA <= taxaB) Console.WriteLine("Como a taxa de crescimento de A é menor ou igual à de B, o País A jamais alcançará o País B.");
            else
            {
                while (popA < popB)
                {
                    popA *= 1 + taxaA / 100;
                    popB *= 1 + taxaB / 100;
                    anos++;
                }
                Console.WriteLine($"Serão necessários {anos} anos para que a população do país A ultrapasse ou iguale a do país B.");
                Console.WriteLine($"População final do País A: {Math.Round(popA):N0} habitantes.");
                Console.WriteLine($"População final do País B: {Math.Round(popB):N0} habitantes.");
            }

            Console.Write("\nDeseja repetir a operação? (S para sim / Qualquer outra tecla para sair): ");
            string resposta = Console.ReadLine().ToUpper();
            if (resposta != "S")
            {
                Console.WriteLine("\nOperação encerrada.");
                break;
            }
        }
    }
    
    //4. Supondo que a população de um país A seja da ordem de 80000 habitantes com uma taxa anual de
    //   crescimento de 3%, e que a população de B seja 200000 habitantes com uma taxa de crescimento de
    //   1.5%. Faça um programa que calcule e escreva o número de anos necessários para que a população
    //   do país A ultrapasse ou iguale a população do país B, mantidas as taxas de crescimento.
    private static void Exercicio4()
    {
        double popA = 80000;
        double popB = 200000;
        var anos = 0;
        while (popA < popB)
        {
            popA = popA * 1.03;
            popB = popB * 1.015;
            anos++;
        }

        Console.WriteLine($"Serão necessários {anos} anos para que a população do país A ultrapasse ou iguale a do país B.");
        Console.WriteLine($"População final do País A: {Math.Round(popA):N0} habitantes.");
        Console.WriteLine($"População final do País B: {Math.Round(popB):N0} habitantes.");
    }

    //3. Faça um programa que leia e valide as seguintes informações:
    //   Nome: maior que 3 caracteres;
    //   Idade: entre 0 e 150;
    //   Salário: maior que zero;
    //   Sexo: 'f' ou 'm';
    //   Estado Civil: 's', 'c', 'v', 'd';

    private static void Exercicio3()
    {
        var nome = "";
        var idade = 0;
        double salario = 0;
        var sexo = "";
        var estado_civil = "";

        Console.WriteLine("--- CADASTRO ---");
        while (true)
        {
            Console.Write("Digite o nome: ");
            nome = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(nome) && nome.Length > 3) break;
            Console.WriteLine("O nome deve ser maior que 3 caracteres.");
            Console.WriteLine("Pressione qualquer tecla para tentar novamente...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("--- CADASTRO ---");
        }

        while (true)
        {
            Console.Write("Digite a idade: ");
            if (int.TryParse(Console.ReadLine(), out idade) && idade >= 0 && idade <= 150) break;
            Console.WriteLine("A idade deve ser um valor válido entre 0 e 150 anos.");
            Console.WriteLine("Pressione qualquer tecla para tentar novamente...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("--- CADASTRO ---");
        }

        while (true)
        {
            Console.Write("Digite o salário: ");
            if (double.TryParse(Console.ReadLine(), out salario) && salario > 0) break;
            Console.WriteLine("O salário deve ser maior que R$ 0.");
            Console.WriteLine("Pressione qualquer tecla para tentar novamente...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("--- CADASTRO ---");
        }

        while (true)
        {
            Console.Write("Digite o sexo (\"F\" ou \"M\"): ");
            sexo = Console.ReadLine().ToUpper();
            if (!string.IsNullOrWhiteSpace(sexo) && (sexo == "F" || sexo == "M")) break;
            Console.WriteLine("O sexo deve ser \"F\" ou \"M\"");
            Console.WriteLine("Pressione qualquer tecla para tentar novamente...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("--- CADASTRO ---");
        }

        while (true)
        {
            Console.Write("Digite o estado civil: ");
            estado_civil = Console.ReadLine().ToUpper();
            if (!string.IsNullOrWhiteSpace(estado_civil) && (estado_civil == "S" || estado_civil == "C" ||
                                                             estado_civil == "V" || estado_civil == "D")) break;
            Console.WriteLine("O estado civil deve ser \"S\", \"C\", \"V\" ou \"D\".");
            Console.WriteLine("Pressione qualquer tecla para tentar novamente...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("--- CADASTRO ---");
        }

        Console.Clear();
        Console.WriteLine("--- CADASTRO FINALIZADO ---");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Salário: {salario}");
        Console.WriteLine($"Sexo: {sexo}");
        Console.WriteLine($"Estado civil: {estado_civil}");
    }

    //2. Faça um programa que leia um nome de usuário e a sua senha e não aceite a senha igual ao nome do
    //   usuário, mostrando uma mensagem de erro e voltando a pedir as informações.
    private static void Exercício2()
    {
        var usuario = "";
        var senha = "";

        while (true)
        {
            Console.WriteLine("--- CADASTRO DE USUÁRIO ---");
            Console.Write("Digite o usuário: ");
            usuario = Console.ReadLine();
            Console.Write("Digite a senha: ");
            senha = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(usuario) && !string.IsNullOrWhiteSpace(senha) && usuario != senha)
            {
                Console.WriteLine("\nUsuário cadastrado com sucesso!");
                break;
            }

            Console.WriteLine("\nErro: A senha não pode ser igual ao usuário (ou os campos estão vazios).");
            Console.WriteLine("Pressione qualquer tecla para tentar novamente...");
            Console.ReadKey();
            Console.Clear();
        }
    }

    //1. Faça um programa que peça uma nota, entre zero e dez. Mostre uma mensagem caso o valor seja
    //   inválido e continue a pedir até que o usuário informe um valor válido.
    private static void Exercício1()
    {
        while (true)
        {
            Console.WriteLine("--- CADASTRO DE NOTA ---");
            Console.Write("Digite uma nota de 0 a 10: ");
            if (double.TryParse(Console.ReadLine(), out var nota) && nota >= 0 && nota <= 10)
            {
                Console.WriteLine("\nNota cadastrada com sucesso!");
                break;
            }

            Console.WriteLine("\nErro: A nota deve ser um valor válido maior ou igual a 0 e menor ou igual a 10.");
            Console.WriteLine("Pressione qualquer tecla para tentar novamente...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}