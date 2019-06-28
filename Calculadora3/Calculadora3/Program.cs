using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculadora3
{
    class Program
    {
        

        static void Main(string[] args)
        {
            
            Calculadora c;
            c = new Calculadora();

            Console.WriteLine("Digite o Primeiro Numero: ");
            c.numero1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Operacao Desejada ( + - * / ): ");
            c.operacao = Console.ReadLine();
          
            Console.WriteLine("Digite o Primeiro Numero: ");
            c.numero2 = decimal.Parse(Console.ReadLine());


            if (c.operacao == "+")
            {
                decimal somaDeValores = c.Somar(c.numero1, c.numero2);
                Console.WriteLine("O resultado da Soma e: {0} ", somaDeValores);
            }
            else if (c.operacao == "-")
            {
                decimal subDeValores = c.Subtrair(c.numero1, c.numero2);
                Console.WriteLine("O resultado da Subtracao e: {0} ", subDeValores);
            }
            else if (c.operacao == "/" && c.numero2 != 0)
            {
                decimal divDeValores = c.Dividir(c.numero1, c.numero2);
                Console.WriteLine("O resultado da Divisao e: {0} ", divDeValores);
            }
            else if (c.operacao == "*")
            {
                decimal multDeValores = c.Multiplicar(c.numero1, c.numero2);
                Console.WriteLine("O resultado da Multiplicacao e: {0} ", multDeValores);
            }
            else
            {
                Console.WriteLine("Operacao Invalida!!");
            }

            Console.ReadKey(true);

            Console.ReadLine();
        }
    }
}
