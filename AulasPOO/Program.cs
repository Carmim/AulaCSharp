﻿// See https://aka.ms/new-console-template for more information
using AulasPOO.uteis;
int opcao = 0, num1, num2, num3;
do
{
    Console.WriteLine("Escolha uma opção: ");
    Console.WriteLine("1) Somar");
    Console.WriteLine("2) Multiplicar");
    Console.WriteLine("3) Fatorial");
    Console.WriteLine("4) Subtrair");
    Console.WriteLine("5) Dividir");
    Console.WriteLine("0) Sair");
    opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao)
    {
        case 0:
            Console.WriteLine("Fim do Programa");
            break;
        case 1:
            LerDoisNumerosInteiros();
            var calc = new Calculadora();
            int resultado = calc.Soma(num1,num2);
            Console.WriteLine($"O resultado da soma de {num1} com {num2} é: {resultado}");
            break;
        case 2:
            LerDoisNumerosInteiros();
            Console.WriteLine($"O resultado da multiplicação de {num1} por {num2} é {Calculadora.Multiplica(num1,num2)}");
            break;
        case 3:
            Console.WriteLine("Entre com o numero: ");
            num3 = int.Parse(Console.ReadLine());
            Console.WriteLine($"O resultado do fatorial de {num3} é {Calculadora.Fatorial(num3)}");
            break;
        case 4:
            LerDoisNumerosInteiros();
            var calc2 = new Calculadora();
            int resultado2 = calc2.Subtrair(num1 ,num2);
            Console.WriteLine($"O resultado da subtração de {num1} por {num2} é {resultado2}");
            break;
        case 5:
            LerDoisNumerosInteiros();
            var (result, resto) = Calculadora.Dividir(num1, num2);
            Console.WriteLine($"O resultado da divisão de {num1} por {num2} é {result} e o resto que sobrou é {resto} ");
            break;
        default:
            Console.WriteLine("Opção Inválida");
            break;
    }
}while (opcao != 0);

void LerDoisNumerosInteiros()
{
    Console.WriteLine("Informe o primeiro numero");
    num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe o segundo numero");
    num2 = int.Parse(Console.ReadLine());
}
