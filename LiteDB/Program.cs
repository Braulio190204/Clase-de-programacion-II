using System;

namespace LiteDB
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string[] matriz = new string[30];

            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("dame los 2 numeros");
                matriz[i] = Console.ReadLine();


            }

            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("estos son los numeros");
                Console.WriteLine(matriz[i]);


            }

        }
    }
}
