using System;

namespace ejercicio2deJONATANPEDALINO
{
    class Program
    {
        static void Main(string[] args)
        {
            double LadoA, LadoB, LadoC;
            Console.WriteLine("Ingrese lado A:");
            LadoA = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese lado B:");
            LadoB = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese lado C:");
            LadoC = double.Parse(Console.ReadLine());
            Console.WriteLine(ObtenerTipoTriangulo(LadoA, LadoB, LadoC));
            double Perimetro = LadoA + LadoB + LadoC;
            Console.WriteLine("Perimetro del Triangulo:" + Perimetro);
        }

        public static string ObtenerTipoTriangulo(double ladoA, double ladoB, double ladoC)
        {
            if (Math.Pow(ladoB, 2) + Math.Pow(ladoC, 2) == Math.Pow(ladoA, 2)) return "El Triangulo Es Rectangulo";
            if (Math.Pow(ladoB, 2) + Math.Pow(ladoC, 2) > Math.Pow(ladoA, 2)) return "El Triangulo Es Obtusangulo";
            if (Math.Pow(ladoB, 2) + Math.Pow(ladoC, 2) < Math.Pow(ladoA, 2)) return "El Triangulo Es Acutangulo";
            return "Error";
        }

        public static double ObtenerArea(double ladoA, double ladoB, double ladoC)
        {
            double SemiPerimetro = (ladoA + ladoB + ladoC) / 2;
            double Area = Math.Sqrt(SemiPerimetro * (SemiPerimetro - ladoA) * (SemiPerimetro - ladoB) * (SemiPerimetro - ladoC));
            return Area;
        }

    }
}
