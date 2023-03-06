using System;

namespace pergunta02
{
    class Program
    {
        static void Main(string[] args)
        {
            int proxvalor = 0;
            int valor1 = 0;
            int valor2 = 1;

            Console.WriteLine("Sequência de Fibonacci");
            Console.Write("Digite um número inteiro: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num == 0)
            {
                Console.WriteLine("O número {0} pertence a seguencia de Fibonacci !", num);
            }
            else
            {
                while (proxvalor != num && proxvalor < num)
                {
                    valor1 = valor2;
                    valor2 = proxvalor;
                    proxvalor = valor1 + valor2;
                }
                if (num == proxvalor)
                {
                    Console.WriteLine("O número {0} pertence a seguencia de Fibonacci !", num);
                }
                else
                {
                    Console.WriteLine("O número {0} NÃO pertence a seguencia de Fibonacci !", num);
                }
            }

            

        }
    }
}
