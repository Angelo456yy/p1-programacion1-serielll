using System;

namespace Correo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido");
            Console.WriteLine("Escribe tu nombre"); 
            string nombre = Console.ReadLine();
            Console.WriteLine("ahora tu apellido");
            String apellido = Console.ReadLine();
            Console.WriteLine("escribe tu dominio (gmail, hotmail, etc )");
            String dominio = Console.ReadLine();
            string A = "@";
            string com = ".com";


            Console.WriteLine("Tu correo es " + nombre+apellido+A+dominio+com);
        }
    }
}
