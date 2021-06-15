using System;

namespace caixa_troco
{
    class Program
    {
        static void Main(string[] args)
        {

            string pagamento = "";
            string precoDoProduto;

            //while ()
            Console.WriteLine("Digite o preço do produto: ");
            precoDoProduto = Console.ReadLine();
            double precoReal = Convert.ToDouble(precoDoProduto);

            Console.WriteLine("Digite o valor do pagamento: ");
            pagamento = Console.ReadLine();
            pagamento = pagamento.ToString();

            while (pagamento != "")
            {
                double pagamentoReal = Convert.ToDouble(pagamento);
                double troco = precoReal - pagamentoReal;

                if (troco == 0)
                    Console.WriteLine("Não precisa de troco");
                else
                    Console.WriteLine("Seu troco é de " + troco);

                Console.WriteLine("Digite o valor do pagamento: ");
                pagamento = Console.ReadLine();
                pagamento = pagamento.ToString();
            }

            Console.WriteLine("Fim");
        }
    }
}
