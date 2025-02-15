using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Ingresa el primer número: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingresa el segundo número: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        
        Console.WriteLine("\nResultados de Comparaciones:");
        Console.WriteLine($"{num1} > {num2} -> {num1 > num2}");
        Console.WriteLine($"{num1} < {num2} -> {num1 < num2}");
        Console.WriteLine($"{num1} == {num2} -> {num1 == num2}");

        
        Console.WriteLine("\nResultados de Operaciones Lógicas:");
        Console.WriteLine($"({num1} > 0 && {num2} > 0) -> {num1 > 0 && num2 > 0}  (Ambos números son positivos)");
        Console.WriteLine($"({num1} < 0 || {num2} < 0) -> {num1 < 0 || num2 < 0}  (Al menos uno es negativo)");
    }
}

