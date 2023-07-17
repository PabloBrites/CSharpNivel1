using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar tres números y emitir un cartel aclaratorio 
            //si la suma de los dos primeros es mayor al producto del segundo con el tercero.

            int n1, n2, n3, suma, producto;

            Console.WriteLine("Ingrese el primer numero:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero:");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero:");
            n3 = int.Parse(Console.ReadLine());

            suma = n1 + n2;
            producto = n2 * n3;

            if(suma > producto)
                Console.WriteLine("La suma es mayor que el producto...");
            else
            Console.WriteLine("Programa terminado.");

            //otra forma de hacerlo.

            //if(n1 + n2 > n2 * n3)
                 
        }       
    }
}
