using System;

namespace Aula01
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota1 = 0;
            int nota2 = 0;
            int nota5 = 0;
            int nota10 = 0;
            int nota20 = 0;
            int nota50 = 0;
            int nota100 = 0;
            int nota200 = 0;

            Console.WriteLine("Digite o valor para retirar:");
            string valorString = Console.ReadLine();
            int valor = Convert.ToInt32(valorString);

            while (valor > 0)
            {
                if (valor >= 200)
                {
                    valor -= 200;
                    nota200++;
                }
                else if (valor >= 100)
                {
                    valor -= 100;
                    nota100++;
                }
                else if (valor >= 50)
                {
                    valor -= 50;
                    nota50++;
                }
                else if (valor >= 20)
                {
                    valor -= 20;
                    nota20++;
                }
                else if (valor >= 10)
                {
                    valor -= 10;
                    nota10++;
                }
                else if (valor >= 5)
                {
                    valor -= 5;
                    nota5++;
                }
                else if (valor >= 2)
                {
                    valor -= 2;
                    nota2++;
                }
                else
                {
                    valor -= 1;
                    nota1++;
                }
            }


            if (nota1 != 0)
            {
                Console.WriteLine(nota1 + " Nota(s) de 1 Real");
            }
            if (nota2 != 0)
            {
                Console.WriteLine(nota2 + " Nota(s) de 2 Reais");
            }
            if (nota5 != 0)
            {
                Console.WriteLine(nota5 + " Nota(s) de 5 Reais");
            }
            if (nota10 != 0)
            {
                Console.WriteLine(nota10 + " Nota(s) de 10 Reais");
            }
            if (nota20 != 0)
            {
                Console.WriteLine(nota20 + " Nota(s) de 20 Reais");
            }
            if (nota50 != 0)
            {
                Console.WriteLine(nota50 + " Nota(s) de 50 Reais");
            }
            if (nota100 != 0)
            {
                Console.WriteLine(nota100 + " Nota(s) de 100 Reais");
            }
            if (nota200 != 0)
            {
                Console.WriteLine(nota200 + " Nota(s) de 200 Reais");
            }


        }
    }
}