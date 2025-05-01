using System;


namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int aprobados = 0;
            int desaprobados = 0;
            int exonerados = 0;

            Console.Write("Ingrese la cantidad de alumnos: ");
            int cant = int.Parse(Console.ReadLine());

            for (int i = 1; i <= cant; i++)
            {
                Console.Write($"Ingrese la nota final del alumno (0 a 20): ");
                int nota = int.Parse(Console.ReadLine());

                if (nota >= 0 && nota <= 20)
                {
                    if (nota >= 18)
                    {
                        exonerados++;
                    }
                    else if(nota >= 10 )
                       {
                        aprobados ++;
                    }
                    else
                    {
                        desaprobados++;
                    }
                }

            }

            Console.WriteLine("\nResultados:");
            Console.WriteLine("aprobados: " + aprobados);
            Console.WriteLine("desaprobados: "+ desaprobados);
            Console.WriteLine("exonerados: " + exonerados);

        }
        }
    }

