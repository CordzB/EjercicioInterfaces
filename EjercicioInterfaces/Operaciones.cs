﻿

namespace EjercicioInterfaces
{
    public class Operaciones : IOperaciones
    {
        public double CalcularArea(double radio)
        {
            return Math.PI * radio * radio;
        }

        public double CalcularPerimetro(double lado)
        {
            return 4 * lado;
        }

        public double CalcularVolumen(double radio, double altura)
        {
            return Math.PI * radio * radio * altura;
        }

        public double CalcularLongitud(double distancia)
        {
            return distancia * 2;
        }

        public double CalcularSuperficie(double largo, double ancho)
        {
            return largo * ancho;
        }

        public void Imprimir()
        {
            Console.WriteLine($"---------RESULTADOS---------");
            Console.WriteLine($"Área: {CalcularArea(5)}m²");
            Console.WriteLine($"Perímetro: {CalcularPerimetro(4)}m");
            Console.WriteLine($"Volumen: {CalcularVolumen(3, 10)}m³");
            Console.WriteLine($"Longitud: {CalcularLongitud(8)}m");
            Console.WriteLine($"Superficie: {CalcularSuperficie(6, 7)}m²");

        }
    }
}

