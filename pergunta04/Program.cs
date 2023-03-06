using System;

namespace pergunta04
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 180759.98;
            double sp = 67836.43;
            double rj = 36678.66;
            double mg = 29229.88;
            double es = 27165.48;
            double outros = 19849.53;

            Console.WriteLine("Representação mensal de Faturamento da distribuidora");
            Console.WriteLine("São Paulo --> {0}% do valor total mensal .", ((sp * 100)/total));
            Console.WriteLine("Rio de Janeiro --> {0}% do valor total mensal .", ((rj * 100) / total));
            Console.WriteLine("Minas Gerais --> {0}% do valor total mensal .", ((mg * 100) / total));
            Console.WriteLine("Espirito Santo --> {0}% do valor total mensal .", ((es * 100) / total));
            Console.WriteLine("Outros --> {0}% do valor total mensal .", ((outros * 100) / total));
        }
    }
}
