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
            int num = 0, cont = 0;

            do
            {
                try
                {
                    Console.Write("\nIngrese un numero: ");
                    if(int.TryParse(Console.ReadLine(), out num))
                    {
                        if (num > 100 || num < 0)
                            Console.WriteLine("Solo se aceptan numeros entre 0 y 100");
                        else if (num > aleatorio)
                            Console.WriteLine(num + " > aleatorio");
                        else if (num < aleatorio)
                            Console.WriteLine(num + " < aleatorio");
                        else
                            encontrado = true;
                    }
                    else
                    {
                        Console.WriteLine("Recuerde solo utilizar numeros");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ocurrio un error en la ejecución.");
                }

                cont++;

            } while (!encontrado);

            Console.WriteLine("Felicidades! Encontró el numero " + aleatorio + " en " + cont + " intentos!");
        }
    }
}
