using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar cuatro números distintos y luego 
            //mostrar por pantalla el menor de ellos.

            int a, b, c, d, aux;

            Console.WriteLine("ingrese un numero:"); 

            a = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese otro:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese otro:");
            c = int.Parse(Console.ReadLine()); 
            Console.WriteLine("ingrese otro:");
            d = int.Parse(Console.ReadLine());

            if(a < b)
                aux = a;
            else 
                aux = b;
            
            if(c < aux)
                aux = c;

            if (d < aux)
                aux = d;
            
            Console.WriteLine("El numero menor es: " + aux); 

        }   
    }
}
