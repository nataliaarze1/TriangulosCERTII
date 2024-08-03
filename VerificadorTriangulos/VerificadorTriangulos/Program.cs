internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese los tres lados del triángulo:");

        Console.Write("Lado 1: ");
        double lado1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Lado 2: ");
        double lado2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Lado 3: ");
        double lado3 = Convert.ToDouble(Console.ReadLine());

        string tipoTriangulo = DeterminarTipoTriangulo(lado1, lado2, lado3);
        Console.WriteLine($"Los lados ingresados forman un triángulo {tipoTriangulo}.");

    }
    static string DeterminarTipoTriangulo(double lado1, double lado2, double lado3)
    {
        if (lado1 == lado2 && lado2 == lado3)
        {
            return "equilátero";
        }
        else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
        {
            return "isósceles";
        }
        else
        {
            return "escaleno";
        }
    }
}