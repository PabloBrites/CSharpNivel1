using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
          //char miChar = 'A', pepe = 'B';
          //Console.WriteLine(miChar);
          //Console.WriteLine(pepe);
        
          //ejemplos de char.

          //Ejemplo de if con ! negacion

          //int edad = 30;
          //char inicial = 'J';

          //if(!(inicial == 'J' || inicial == 'H') && edad > 20){
              //Console.WriteLine("21 OFF");
          //}
          //Console.WriteLine("fin programa");

          //si inicial no es igual a 'J' ni igual a 'H'. En otras palabras, si el valor de inicial
          //es diferente tanto de 'J' como de 'H', el código dentro del if se ejecutará.

         //Hacer un programa que solicite el ingreso de dos números y luego calcular:

            //*La resta si el primero es mayor que el segundo.
            //*La suma si son iguales.
            //*El producto si el primero es menor.
            //Se debera emitir un cartel por pantalla con el resultado correspondiente.
            
            int n1, n2, n3 = 0;

            Console.WriteLine("Ingrese un numero:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese otro:");
            n2 = int.Parse(Console.ReadLine());
            
            if(n1 > n2)
                n3 = n1 - n2;
            else if(n1 == n2)
                n3 = n1 + n2;
            else if(n1 < n2)
                n3 = n1 * n2;
            
            Console.WriteLine("El resultado es: " + n3);
            
           
        }
    }
}
