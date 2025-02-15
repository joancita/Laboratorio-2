using System;

class Program
{
    static void Main()
    {
        // Pedir la edad al usuario
        Console.Write("Ingresa tu edad: ");
        int edad = Convert.ToInt32(Console.ReadLine());

        // Clasificación de edad con if-else
        if (edad < 12)
        {
            Console.WriteLine("Eres un Niño.");
        }
        else if (edad >= 12 && edad <= 17)
        {
            Console.WriteLine("Eres un Adolescente.");
        }
        else if (edad >= 18 && edad <= 59)
        {
            Console.WriteLine("Eres un Adulto.");
        }
        else
        {
            Console.WriteLine("Eres un Adulto mayor.");
        }
    }
}

