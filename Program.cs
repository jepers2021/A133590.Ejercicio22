using System;

namespace A133590.Ejercicio22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 22");
            Console.WriteLine("Programa que presenta al usuario la fecha actual en formato dd/MM/yyyy.");

            Console.WriteLine($"La fecha actual es: {DateTime.Now.ToString("dd/MM/yyyy")}");

            Console.WriteLine("Presione cualquier tecla para salir..");
            Console.ReadKey();
        }
    }
}
