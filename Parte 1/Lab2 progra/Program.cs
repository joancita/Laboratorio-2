using System;

class Program
{
    static void Main()
    {
        int numeroEntero;
        double numeroDecimal;
        string texto;
        bool valorBooleano;

        Console.Write("Ingresa un número entero: ");
        numeroEntero = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingresa un número decimal: ");
        numeroDecimal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa un texto: ");
        texto = Console.ReadLine();

        Console.Write("Ingresa un valor verdadero o falso (true/false): ");
        valorBooleano = Convert.ToBoolean(Console.ReadLine());

        Console.WriteLine("\nValores ingresados:");
        Console.WriteLine("Número entero: " + numeroEntero);
        Console.WriteLine("Número decimal: " + numeroDecimal);
        Console.WriteLine("Texto: " + texto);
        Console.WriteLine("Valor booleano: " + valorBooleano);
    }
}
