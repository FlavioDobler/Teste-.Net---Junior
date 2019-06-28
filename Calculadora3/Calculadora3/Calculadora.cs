using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora3

{
    public class Calculadora
    {


       public string operacao;

       public decimal resultado;
       public decimal numero1 { get; set; }

       public decimal numero2 { get; set; }

        public decimal Somar(decimal numero1, decimal numero2)
        {
           return  this.numero1 + this.numero2;
        }

        public decimal Subtrair(decimal numero1, decimal numero2)
        {
            return  this.numero1 - this.numero2;
           
        }

        public decimal Multiplicar(decimal numero1, decimal numero2)
        {
            return this.numero1 * this.numero2;
           
        }
        public decimal Dividir(decimal numero1, decimal numero2)
        {
            if (numero2 == 0)
            {
                Console.WriteLine("Nao se pode dividir por zero ");
                return 0;
            }
            else
            return  this.numero1 / this.numero2;
          
        }


    }
}





/*{
                try
                {
                    resultado = numero1 / numero2;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Nao se pode dividir {0} por zero.", numero1);     
                }
                resultado = numero1 / numero2;
                Console.WriteLine("O resultado da Divisao e: {0} ", resultado);
            }
*/
