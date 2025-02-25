using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Operacoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome: ");
            String nome = Console.ReadLine();

            Console.Write("\nDigite sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            
            Console.WriteLine("\nOlá " + nome + ", você tem " + idade + " anos.\n");

            Console.Write("\nAgora digite um número: ");
            double primeiroNumero = double.Parse(Console.ReadLine());

            Console.Write("\nAgora digite outro número: ");
            double segundoNumero = double.Parse(Console.ReadLine());

            if (primeiroNumero > segundoNumero)
            {
                Console.WriteLine($"\n{primeiroNumero} é maior que {segundoNumero}.\n");
            }
            else if (primeiroNumero == segundoNumero)
            {
                Console.WriteLine($"\n{primeiroNumero} é igual a {segundoNumero}.\n");
            }
            else
            {
                Console.WriteLine($"\n{segundoNumero} é maior que {primeiroNumero}.\n");
            }

            Console.WriteLine($"\nA soma dos números é: {primeiroNumero + segundoNumero}.\n");
            Console.WriteLine($"\nA subtração dos números é: {primeiroNumero - segundoNumero}.\n");
            Console.WriteLine($"\nA multiplicação dos números é: {primeiroNumero * segundoNumero}.\n");
            Console.WriteLine($"\nA divisão dos números é: {primeiroNumero / segundoNumero}.\n");

            Console.WriteLine("\nPressione qualquer tecla!");
            Console.ReadKey();
        }
    }
}
