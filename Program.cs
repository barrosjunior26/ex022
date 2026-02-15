using System;

namespace ex022
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variáveis globais
            string[] lista;
            byte quantidade;

            Console.Clear();
            Console.WriteLine("========== Lista de compras ==========");
            Console.Write("Digite a quantidade de itens que deseja adicionar a lista: ");
            quantidade = Convert.ToByte(Console.ReadLine());

            lista = new string[quantidade];

            for (int i = 0; i < lista.Length; i++)
            {
                Console.Write($"Informe o {i + 1}º item: ");
                lista[i] = Convert.ToString(Console.ReadLine());
            }

            Console.WriteLine("\n\n ========== Itens da sua lista ==========");

            foreach (var itens in lista)
            {
                Console.WriteLine(itens);
            }
        }
    }
}
