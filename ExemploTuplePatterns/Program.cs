using System;

namespace ExemploTuplePatterns
{
    class Program
    {
        private static double ConverterAltura(
            Medida alturaOriginal, Medida alturaResultado, double valor)
        => (alturaOriginal, alturaResultado) switch
        {
            (Medida.Pes, Medida.Metros) => Math.Round(valor * 0.3048, 4),
            (Medida.Metros, Medida.Pes) => Math.Round(valor * 3.281, 2),
            (_, _) => throw new ArgumentException("Conversão inválida!")
        };

        static void Main()
        {
            double valor;

            valor = 10;
            Console.WriteLine($"Pés: {valor}, " +
                $"Metros: {ConverterAltura(Medida.Pes, Medida.Metros, valor) }");

            valor = 30.48;
            Console.WriteLine($"Metros: {valor}, " +
                $"Pés: {ConverterAltura(Medida.Metros, Medida.Pes, valor) }");

        }
    }
}