using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace TP.Aula03Exer01
{
    internal static class Program
    {
        static void Main(string[] args)
        {

            int[] numeros = new int[10];
            int[] numerosPares = new int[5];
            int[] numerosImpares = new int[5];

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = i + 1;
            }

            for (int j = 0; j < numeros.Length; j++)
            {
                if (numeros[j] % 2 == 0)
                {
                    numerosPares[j/2] = numeros[j];
                }

                else
                {
                    numerosImpares[j/2] = numeros[j];
                }
            }

            for (int m = 0; m < numeros.Length; m++)
            {
                Console.WriteLine(numeros[m]);
            }

            Console.WriteLine("_____________________\n");

            for (int n = 0; n < numerosPares.Length; n++)
            {
                Console.WriteLine(numerosPares[n]);
            }

            Console.WriteLine("_____________________\n");

            for (int o = 0; o < numerosImpares.Length; o++)
            {
                Console.WriteLine(numerosImpares[o]);
            }
        }

    }

}
