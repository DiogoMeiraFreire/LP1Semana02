using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indique a altura do cilindro: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Indique o raio do cilindro: ");
            float r = float.Parse(Console.ReadLine());

            float Volume = MathF.PI * MathF.Pow(r, 2) * a;
            float Sa = 2 * MathF.PI * r * (r + a);

            Console.WriteLine(Volume);
            Console.WriteLine(Sa);
        }
    }
}
