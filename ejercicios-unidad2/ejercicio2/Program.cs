using System;

namespace ejercicios_unidad2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para solicitar por teclado un número 
            //y luego devolver su valor elevado al cubo.

            int n, cubo;

            //pedir nro 
            Console.WriteLine("Ingrese un nro");
            n = int.Parse(Console.ReadLine());

            //elvar al cubo
            cubo = n * n * n;

            //mostrar resultado
            Console.WriteLine("El valor elevado al cubo es:" + cubo);

            
        }
    }
}
