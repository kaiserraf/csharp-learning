using System;
namespace CalculadoraSimples
{
    class Program
    {
        static void Main(String[] args)
        {
            double valor1, valor2;
            double resultado;
            char operador;

            Console.WriteLine("-----CALCULADORA-----");

            while (true)
            {
                Console.WriteLine("Digite o primeiro valor: ");
                valor1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o operador: ");
                operador = char.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo valor: ");
                valor2 = double.Parse(Console.ReadLine());

                switch (operador)
                {
                    case '+':
                        resultado = valor1 + valor2;
                        Console.WriteLine($"{valor1} {operador} {valor2} = {resultado} ");
                        break;

                    case '-':
                        resultado = valor1 - valor2;
                        Console.WriteLine($"{valor1} {operador} {valor2} = {resultado} ");
                        break;

                    case '*':
                        resultado = valor1 * valor2;
                        Console.WriteLine($"{valor1} {operador} {valor2} = {resultado} ");
                        break;

                    case '/':
                        if (valor2 == 0)
                        {
                            Console.WriteLine("Erro! Divisão por 0... Tente novamente");
                            continue;
                        }
                        else
                        {
                            resultado = valor1 / valor2;
                            Console.WriteLine($"{valor1} {operador} {valor2} = {resultado} ");
                        }
                        break;

                    default:
                        Console.WriteLine("Operador invalido");
                        break;
                }
            }
        }
    }
}