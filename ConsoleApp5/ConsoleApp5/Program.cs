using System;

namespace vetor0Por2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5];

            numeros[0] = 12;
            numeros[1] = 7;
            numeros[2] = 15;
            numeros[3] = 11;
            numeros[4] = 27;

               int aux = numeros[0];
                numeros[0] = numeros[2];
                numeros[2] = aux;

            Console.WriteLine("Meus numeros são:{0} {1} {2} {3} {4}", numeros[0], numeros[1], numeros[2], numeros[3], numeros[4]);

            Console.ReadKey(true);

        }
    }
}
