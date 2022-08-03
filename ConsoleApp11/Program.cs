using System;
using System.Globalization;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, areaTri, areaCir, areaTra, areaQua, areaRet;

            string[] vet = Console.ReadLine().Split(' ');

            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            areaTri = a * c / 2;
            areaCir = 3.14159 * Math.Pow(c, 2.0);
            areaTra = (a + b) * c / 2;
            areaQua = Math.Pow(b, 2.0);
            areaRet = (a * b);


            Console.WriteLine("TRIANGULO = " + areaTri.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO = " + areaCir.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO = " + areaTra.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO = " + areaQua.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO = " + areaRet.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
