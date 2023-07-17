using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar cuatro numeros y luego
            //mostrar por pantalla cuales son mayores a 100

            int a, b, c, d, contador = 0;

            Console.WriteLine("Ingrese un numero:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro:");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro:");
            d = int.Parse(Console.ReadLine());

            if(a > 100){
               Console.WriteLine("El primer numero: " + a + " es mayor a 100");
               contador++;
            }
            if(b > 100){
               Console.WriteLine("El segundo numero: " + b + " es mayor a 100");
               contador++;
            }
            if(c > 100){
               Console.WriteLine("El tercer numero: " + c + " es mayor a 100");
               contador++;
            }
            if(d > 100){
               Console.WriteLine("El cuarto numero: " + d + " es mayor a 100");
               contador++;                  
            }
            if (contador == 0)
            {
             Console.WriteLine("No hay números mayores a 100");
            }
            else
            {
             Console.WriteLine("La cantidad de números mayores a 100 son: " + contador);
            }

            //se utiliza un if adicional para verificar si contador es igual a 0. Si es así, 
            //significa que no se encontró ningún número mayor a 100, y se muestra el mensaje 
            //"No hay números mayores a 100".
            //En caso contrario, se imprime el mensaje "La cantidad de números mayores a 100 es:
            //seguido del valor de contador, que representa la cantidad de números mayores a 100
            //encontrados.

        }
    }
}
