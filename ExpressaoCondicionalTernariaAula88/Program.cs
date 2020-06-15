using System;
using System.Globalization;

namespace ExpressaoCondicionalTernariaAula88
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um valor: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();


            // utilizando expressao condicional ternaria:
            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;


            /*
             double desconto; 
                           
            if (preco < 20)
            {
                desconto = preco * 0.1;  // 10%
            }
            else
            {
                desconto = preco * 0.05; // 5%
            }
            */

            Console.WriteLine("Desconto concedido : " + desconto + "%");

        }
    }
}
