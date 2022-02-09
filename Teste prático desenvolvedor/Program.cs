using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_prático_desenvolvedor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Double> lista = new List<Double>();

            Console.WriteLine("----- Função para o calculo da media e mediana e conceito -------- ");
            Console.WriteLine();
            Console.WriteLine("digite a quantidade de numeros pretendidos");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os numeros decimais pretendidos");
            for (int i = 0; i < n; i++)
            {
                Double a = Double.Parse(Console.ReadLine());
                lista.Add(a);
            }

            double media = lista.Average();
            double mediana = Mediana(lista);


            
            Console.WriteLine("Media: " + media);
            Console.WriteLine("Mediana: " + mediana);

            while (media != 0)
            {
                if (media >= 9.0)
                {
                    Console.WriteLine("Conceito = A");

                }
                else if (media >= 7.5 && media < 9.0)
                {
                    Console.WriteLine("Conceito = B");

                }
                else if (media >= 6.0 && media < 7.5)
                {
                    Console.WriteLine("Conceito = C");

                }
                else if (media >= 4.0 && media < 6.0)
                {
                    Console.WriteLine("Conceito = D");

                }
                else if (media > 4)
                {
                    Console.WriteLine("Conceito = E");
                }
                break;
            }
            Console.WriteLine("\n\nDigite Enter para Sair");
            Console.ReadLine();
        }

        static public double Mediana(List<double> lista)
        {
            double[] listaOrdenada = lista.ToArray();
            Array.Sort(listaOrdenada);

            double totalMediana = 0.0;

            bool impar = (listaOrdenada.Length % 2 != 0);
            if (impar)
            {
                int pos = (listaOrdenada.Length + 1) / 2;
                totalMediana = listaOrdenada[pos - 1];
            }
            else
            {
                int pos1 = (listaOrdenada.Length / 2);
                int pos2 = (listaOrdenada.Length / 2) + 1;

                totalMediana = (listaOrdenada[pos1 - 1] + listaOrdenada[pos2 - 1]) / 2;
            }

            return totalMediana;
        }
    }
}