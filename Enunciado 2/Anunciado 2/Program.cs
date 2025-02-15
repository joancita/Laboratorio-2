using System;

class Program
{
    static void Main()
    {
        // Pedir un número al usuario
        Console.Write("Ingresa un número del 1 al 7: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        // Determinar el día de la semana con switch
        switch (numero)
        {
            case 1:
                Console.WriteLine("Lunes");
                break;
            case 2:
                Console.WriteLine("Martes");
                break;
            case 3:
                Console.WriteLine("Miércoles");
                break;
            case 4:
                Console.WriteLine("Jueves");
                break;
            case 5:
                Console.WriteLine("Viernes");
                break;
            case 6:
                Console.WriteLine("Sábado");
                break;
            case 7:
                Console.WriteLine("Domingo");
                break;
            default:
                Console.WriteLine("Número fuera de rango. Debe ser del 1 al 7.");
                break;
        }
    }
}

