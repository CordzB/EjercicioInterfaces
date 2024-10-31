using EjercicioInterfaces;

class Program
{
    static void Main(string[] args)
    {
        Operaciones operaciones = new Operaciones();

        Console.WriteLine("Ingrese el radio para el área:");
        double radio = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Área: {operaciones.CalcularArea(radio)}m²");
        Console.WriteLine("-------------------------------------");

        Console.WriteLine("Ingrese el lado para el perímetro:");
        double lado = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Perímetro: {operaciones.CalcularPerimetro(lado)}m");
        Console.WriteLine("-------------------------------------");

        Console.WriteLine("Ingrese el radio y altura para el volumen:");
        double radioVolumen = Convert.ToDouble(Console.ReadLine());
        double altura = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Volumen: {operaciones.CalcularVolumen(radioVolumen, altura)}m³");
        Console.WriteLine("-------------------------------------");

        Console.WriteLine("Ingrese la distancia para la longitud:");
        double distancia = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Longitud: {operaciones.CalcularLongitud(distancia)}m");
        Console.WriteLine("-------------------------------------");

        Console.WriteLine("Ingrese el largo y el ancho para la superficie:");
        double largo = Convert.ToDouble(Console.ReadLine());
        double ancho = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Superficie: {operaciones.CalcularSuperficie(largo, ancho)}m²");

        operaciones.Imprimir();
    }
}