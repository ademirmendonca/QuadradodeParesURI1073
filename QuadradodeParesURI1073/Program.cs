using System;
using System.Globalization;

namespace QuadradodeParesURI1073
{
    class Program
    {
        static void Main(string[] args)
        {
            //Recebe o número informado
            double n = double.Parse(Console.ReadLine());            
            
            for (int i = 2; i <= n; i++)
            {
                //Verifica os números pares e executa o cálculo
                if (i % 2 == 0)
                {
                    double resultado = 0;
                    resultado = Math.Pow(i, 2);
                    Console.WriteLine(i + "^2" + " = " + resultado);
                }
            }
        }
    }
}
