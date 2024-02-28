using System;

namespace SmoothOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insere número inteiro não-negativo: ");
            
            byte n = byte.Parse(Console.ReadLine());

            Console.WriteLine(--n);
            Console.WriteLine(++n);
        }
    }
}
