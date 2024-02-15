using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite 10 números enteros y los guarde en un vector. 
            //Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores 
            //que son mayores al promedio.

            int n;
            float promedio = 0;
            int acu = 0;

            int[] enteros = new int[10];

            for (int x = 0; x < 10; x++)
            {   
                Console.WriteLine("Ingrese un numero por favor...");
                n = int.Parse(Console.ReadLine());
                enteros[x] = n;

            }

            for (int x = 0; x < 10; x++)
            {
                acu += enteros[x];

            }
            
            promedio = (float)acu / 10;
            Console.Write("El Promedio es: " + promedio);

            Console.Write(" los numeros dentro del vector mayores al promedio son: ");
            for (int x = 0; x < 10; x++)
            {
                if(enteros[x] > promedio)
                Console.Write(enteros[x] + " ");
            }       
        }
    }
}
