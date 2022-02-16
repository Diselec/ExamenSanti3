using System;

namespace Parejas
{
    class Program
    {
        static void Main(string[] args)
        {
            var sistema = new Sistema();

            var parejas = sistema.PosibleP(sistema.Personas);
            parejas.ForEach(p=> Console.WriteLine($"{p.Item1} {p.Item2}"));
        }
    }
}
