using System;

class Program
{
    static void Main()
    {
        // Datos de acceso correctos
        string usuarioCorrecto = "joan";
        string contraseñaCorrecta = "1234";

        // Pedir usuario y contraseña al usuario
        Console.Write("Ingresa tu usuario: ");
        string usuario = Console.ReadLine();

        Console.Write("Ingresa tu contraseña: ");
        string contraseña = Console.ReadLine();

        // Verificar credenciales
        if (usuario == usuarioCorrecto && contraseña == contraseñaCorrecta)
        {
            Console.WriteLine("Acceso concedido.");
        }
        else if (usuario == usuarioCorrecto && contraseña != contraseñaCorrecta)
        {
            Console.WriteLine("Contraseña incorrecta.");
        }
        else
        {
            Console.WriteLine("Usuario no registrado.");
        }
    }
}

