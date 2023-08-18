using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Hacer un programa para ingresar por teclado dos números y luego informar por pantalla la
            //diferencia absoluta entre ambos.
            //Ejemplo 1: Si se ingresan 3 y 8, se emite 5. Si se ingresan 8 y 3, se emite 5.
            //Ejemplo 2: Si se ingresan -3 y 9, se emite 12. Si se ingresan -12 y -1, se emite 11.


            int n1, n2, diferenciaAbsoluta;
            
            Console.WriteLine("ingrese un numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un numero");
            n2 = int.Parse(Console.ReadLine());

            diferenciaAbsoluta = Math.Abs(n1 - n2);

            Console.WriteLine("la diferencia absoluta entre los numeros es: " + diferenciaAbsoluta);
            
            // Con Math.Abs(n1 - n2), estás calculando la diferencia entre n1 y n2 
            //y luego tomando el valor absoluto de esa diferencia. Esto asegurará que el resultado sea siempre positivo 
            //independientemente de si n1 es mayor o menor que n2.
        }
    }
}
