using System;
using System.Globalization;

namespace Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Triangulo, Circulo, Trapezio, Quadrado, Retangulo, Pi = 3.14159;
            double[] Valores = new double[3];
            for (int i = 0; i < Valores.Length; i++)
            {
                Console.Write("Digite o " + (i + 1) + "° valor: ");
                Valores[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Triangulo = (Valores[0] * Valores[2]) / 2;
            Circulo = Math.Pow(Valores[2], 2) * Pi;
            Trapezio = (Valores[0] + Valores[1]) * Valores[2] / 2;
            Quadrado = Math.Pow(Valores[1], 2);
            Retangulo = Valores[0] * Valores[1];

            Console.WriteLine("TRIANGULO: " + Triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + Circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + Trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + Quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + Retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}