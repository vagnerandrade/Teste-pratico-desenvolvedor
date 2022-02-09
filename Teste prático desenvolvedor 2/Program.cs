using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_prático_desenvolvedor_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------- Caixa eletronico -----------");
            Console.WriteLine();

            Console.WriteLine(" Digite o valor do saque");
            int saque = int.Parse(Console.ReadLine());
            Console.WriteLine();


            Console.WriteLine("total de cedulas:");
            Console.WriteLine($"cedulas de 100: {saque / 100}  ");
            saque -= saque / 100 * 100;
            Console.WriteLine();
            Console.WriteLine($"cedulas de 50: {saque / 50}  ");
            saque = saque % 50;
            Console.WriteLine();
            Console.WriteLine($"cedulas de 20: {saque / 20}  ");
            saque = saque % 20;
            Console.WriteLine();
            Console.WriteLine($"cedulas de 10: {saque / 10}  ");
            saque = saque % 10;
            Console.WriteLine();
            Console.WriteLine($"cedulas de 5: {saque / 5}  ");
            saque = saque % 5;
            Console.WriteLine();
            Console.WriteLine($"cedulas de 2: {saque / 2}  ");
            saque = saque % 2;

            Console.WriteLine("\n Digite enter para sair");
            Console.ReadLine();
        }
    }
}
