using System;

namespace EjercicioClase01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adivine el numero aleatorio.");

            bool encontrado = false;
            int aleatorio = new Random().Next(101); //numero entre 0 y 100
            int num = 0;

            do
            {
                Console.Write("\nIngrese un numero: ");
                num = Convert.ToInt32(Console.ReadLine());

                if (num > aleatorio)
                {
                    Console.WriteLine(num + " > aleatorio");
                }
                else if (num < aleatorio)
                {
                    Console.WriteLine(num + " < aleatorio");
                }
                else
                {
                    Console.WriteLine("Felicidades! Encontró el numero!");
                    encontrado = true;
                }

            } while (!encontrado);
        }
    }
}
