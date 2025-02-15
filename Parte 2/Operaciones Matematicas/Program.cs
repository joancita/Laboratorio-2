using System;

class Program
{
    static void Main()
    {
        // Pedir valores al usuario para los diferentes tipos de datos

        // INT
        Console.Write("Ingresa un número entero (int): ");
        int numInt1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingresa otro número entero (int): ");
        int numInt2 = Convert.ToInt32(Console.ReadLine());

        // FLOAT
        Console.Write("Ingresa un número decimal (float): ");
        float numFloat1 = float.Parse(Console.ReadLine());
        Console.Write("Ingresa otro número decimal (float): ");
        float numFloat2 = float.Parse(Console.ReadLine());

        // DOUBLE
        Console.Write("Ingresa un número decimal (double): ");
        double numDouble1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingresa otro número decimal (double): ");
        double numDouble2 = Convert.ToDouble(Console.ReadLine());

        // INT16
        Console.Write("Ingresa un número pequeño (Int16): ");
        short numShort1 = Convert.ToInt16(Console.ReadLine());
        Console.Write("Ingresa otro número pequeño (Int16): ");
        short numShort2 = Convert.ToInt16(Console.ReadLine());

        // BYTE
        Console.Write("Ingresa un número pequeño (byte, entre 0 y 255): ");
        byte numByte1 = Convert.ToByte(Console.ReadLine());
        Console.Write("Ingresa otro número pequeño (byte, entre 0 y 255): ");
        byte numByte2 = Convert.ToByte(Console.ReadLine());

        // Realizar operaciones y mostrar resultados
        Console.WriteLine("\nResultados:");

        // Operaciones con int
        Console.WriteLine($"Suma de int: {numInt1} + {numInt2} = {numInt1 + numInt2}");
        Console.WriteLine($"Resta de int: {numInt1} - {numInt2} = {numInt1 - numInt2}");
        Console.WriteLine($"Multiplicación de int: {numInt1} * {numInt2} = {numInt1 * numInt2}");
        Console.WriteLine($"División de int: {numInt1} / {numInt2} = {(numInt2 != 0 ? (numInt1 / numInt2).ToString() : "Error: División por 0")}");

        // Operaciones con float
        Console.WriteLine($"\nSuma de float: {numFloat1} + {numFloat2} = {numFloat1 + numFloat2}");
        Console.WriteLine($"Resta de float: {numFloat1} - {numFloat2} = {numFloat1 - numFloat2}");
        Console.WriteLine($"Multiplicación de float: {numFloat1} * {numFloat2} = {numFloat1 * numFloat2}");
        Console.WriteLine($"División de float: {numFloat1} / {numFloat2} = {(numFloat2 != 0 ? (numFloat1 / numFloat2).ToString() : "Error: División por 0")}");

        // Operaciones con double
        Console.WriteLine($"\nSuma de double: {numDouble1} + {numDouble2} = {numDouble1 + numDouble2}");
        Console.WriteLine($"Resta de double: {numDouble1} - {numDouble2} = {numDouble1 - numDouble2}");
        Console.WriteLine($"Multiplicación de double: {numDouble1} * {numDouble2} = {numDouble1 * numDouble2}");
        Console.WriteLine($"División de double: {numDouble1} / {numDouble2} = {(numDouble2 != 0 ? (numDouble1 / numDouble2).ToString() : "Error: División por 0")}");

        // Operaciones con Int16
        Console.WriteLine($"\nSuma de Int16: {numShort1} + {numShort2} = {numShort1 + numShort2}");
        Console.WriteLine($"Resta de Int16: {numShort1} - {numShort2} = {numShort1 - numShort2}");
        Console.WriteLine($"Multiplicación de Int16: {numShort1} * {numShort2} = {numShort1 * numShort2}");
        Console.WriteLine($"División de Int16: {numShort1} / {numShort2} = {(numShort2 != 0 ? (numShort1 / numShort2).ToString() : "Error: División por 0")}");

        // Operaciones con byte
        Console.WriteLine($"\nSuma de byte: {numByte1} + {numByte2} = {numByte1 + numByte2}");
        Console.WriteLine($"Resta de byte: {numByte1} - {numByte2} = {numByte1 - numByte2}");
        Console.WriteLine($"Multiplicación de byte: {numByte1} * {numByte2} = {numByte1 * numByte2}");
        Console.WriteLine($"División de byte: {numByte1} / {numByte2} = {(numByte2 != 0 ? (numByte1 / numByte2).ToString() : "Error: División por 0")}");

    }
}

