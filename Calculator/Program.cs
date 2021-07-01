using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
        First:
            Console.Clear();

            Console.Write("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("Escolha o símbolo da operação desejada (+ - x /): ");
            char operation = char.Parse(Console.ReadLine());

            double result = 0;

            switch (operation)
            {
                default:
                    Console.WriteLine("Por favor, digite uma opção válida");
                    goto First;
                case '+':
                    result = num1 + num2;
                    Console.WriteLine("A operação escolhida foi de adição e o resultado é: " + result);
                    break;
                case '-':
                    result = num1 - num2;
                    Console.WriteLine("A operação escolhida foi de subtração e o resultado é: " + result);
                    break;
                case 'x':
                    result = num1 * num2;
                    Console.WriteLine("A operação escolhida foi de multiplicação e o resultado é: " + result);
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Não é possível efetuar divisão por 0");
                    } else
                    {
                        result = num1 / num2;
                        Console.WriteLine("A operação escolhida foi de divisão e o resultado é: " + result);
                    }
                    break;
            }

            Console.WriteLine("Continuar calculando? (s / n): ");
            string choice = Console.ReadLine();

            if (choice == "s" || choice == "S")
            {
                goto First;
            }
        }
    }
}
