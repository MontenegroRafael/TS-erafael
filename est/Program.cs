using System;

namespace est
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int ind = 13;
            int k = 0;
            int soma = 0;
            while (k < ind)
            {
                k = k + 1;
                soma = soma + k;
            }

            Console.WriteLine(soma);
        }
    }
}
