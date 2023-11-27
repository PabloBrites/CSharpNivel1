using System;
using System.Data.Common;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos. 
            //Luego hacer un programa que pida el precio de un artículo y la cantidad vendida 
            //y muestre por pantalla el monto total a pagar. Usar la función.

            int precio, cantidad, montoTotal;

            Console.WriteLine("Ingrese precio del articulo:");
            precio = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendida:");
            cantidad = int.Parse(Console.ReadLine());

            montoTotal = producto(precio, cantidad);

            Console.WriteLine("El monto total a pagar es : " + montoTotal);
        }

        static int producto(int precio, int cantidad){
            int R;
            R = precio * cantidad;
            return R;
        }   
    }
}
