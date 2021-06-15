using System;

namespace Aula01
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            Console.WriteLine("Digite o preço do produto:");
            string precoProdutoString = Console.ReadLine();
            double precoProduto = Convert.ToDouble(precoProdutoString);

            // 2
            Console.WriteLine("Digite o valor do pagamento:");
            string pagamentoString = Console.ReadLine();
            double pagamentoValor = Convert.ToDouble(pagamentoString);

            // 3 e 4
            while (pagamentoString != "")
            {
                if (pagamentoValor < precoProduto)
                    Console.WriteLine("Valor de pagamento insuficiente!");
                else if (pagamentoValor > precoProduto)
                    Console.WriteLine("O troco é de " + (pagamentoValor - precoProduto));
                else if (pagamentoValor == precoProduto)
                    Console.WriteLine("Não houve de troco");

                Console.WriteLine("Digite o valor do pagamento:");
                pagamentoString = Console.ReadLine();
                pagamentoValor = Convert.ToDouble(pagamentoString);
            }
            Console.WriteLine("Compra Interrompida");
        }
    }
}