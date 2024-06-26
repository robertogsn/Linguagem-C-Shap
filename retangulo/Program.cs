using System;
using System.Globalization;

namespace retangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double Base,Altura,Area,Perimetro,Diaconal;

            Console.Write("Base do ratangulo: ");
            Base = double.Parse(Console.ReadLine(),CI);
            Console.Write("Altura do retangulo: ");
            Altura = double.Parse(Console.ReadLine(),CI);

            Area = Base*Altura;
            Perimetro = 2*(Base+Altura);

            Diaconal = Math.Sqrt(Math.Pow(Base,2.0)+ Math.Pow(Altura ,2.0));

            Console.WriteLine("Area = "+ Area.ToString("F4",CI));
            Console.WriteLine("Perimetro = "+Perimetro.ToString("F4", CI));
            Console.WriteLine("Diagonal = "+ Diaconal.ToString("F4", CI));


        }
    }
}
