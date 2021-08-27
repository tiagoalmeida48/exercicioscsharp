using System;

namespace ExercicioContaAPagar
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo, quantidade;
            double preco = 0.0;

            Console.WriteLine("CÓDIGO   ESPECIFICAÇÃO         PREÇO ");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("1        Cachorro Quente      R$ 4,00");
            Console.WriteLine("2        X-Salada             R$ 4,50");
            Console.WriteLine("3        X-Bacon              R$ 5,00");
            Console.WriteLine("4        Torrada simples      R$ 2,00");
            Console.WriteLine("5        Refrigerante         R$ 1,50");
            Console.WriteLine("=====================================");
            Console.WriteLine("");

            Console.Write("Digite o código: ");
            codigo = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade: ");
            quantidade = int.Parse(Console.ReadLine());

            switch (codigo)
            {
                case 1: 
                    preco = 4 * quantidade; 
                    break;
                case 2: 
                    preco = 4.5 * quantidade; 
                    break;
                case 3: 
                    preco = 5 * quantidade; 
                    break;
                case 4: 
                    preco = 2 * quantidade; 
                    break;
                case 5: 
                    preco = 1.5 * quantidade; 
                    break;
                default:
                    break;
            }
            Console.WriteLine("");
            Console.WriteLine("Total: R$ {0:f2}", preco);
        }
    }
}
