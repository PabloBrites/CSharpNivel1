using System;
using System.Timers;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es. 
            //Hacer un programa para ingresar números. El lote corta cuando se ingresa un número cero. 
            //Informar el promedio teniendo en cuenta sólo los números primos
            //(osea sumar todos los numeros que sean primos y dividirlos y dividirlos por la cantidad de numeros que
            // sean primos) (un promedio es la suma de todos los elementos dividido la cantidad de esos elementos)

            int n, conPrimos = 0, acuPrimos = 0, promedio;

            Console.WriteLine("Ingrese un numero:");
            n = int.Parse(Console.ReadLine());
            while(n != 0)
            {
            
                if(primo(n)){  //si primo es verdadero? osea que resolvio en true, cuenta y acumula.
                conPrimos++;   //osea que vos analizas con la funcion primo es si el valor que esta en "n" es primo o no.
                acuPrimos+=n;
                }
                Console.WriteLine("Ingrese un numero:");
                n = int.Parse(Console.ReadLine());
            }
            promedio = acuPrimos / conPrimos;
            Console.WriteLine("El promedio de los primos es: " + promedio);
        }

        static bool primo(int n1){
                 
            int con = 0;
            
            for (int x = 2; x < n1; x++)
            if(n1 % x == 0)                 // aca se buesca si n1 tiene otro divisor, porque un numero primo es divisible
            con++;                          // por 1 y por el mismo numero, osea que si hay otro divisor ese numero no es
                                            // primo, osea que si el contador queda en cero significa que no se encontro
            if(con == 0)                    // otro divisor. 
                return true;
            else
                return false;
            
        }              
    }   
}
            
    //¿entonces el retorno de la funcion va a parar a n?      

    //No, el retorno de la función primo no se asigna directamente a la variable n. 
    //La variable n sigue conteniendo el número original ingresado por el usuario. 
    //El valor devuelto por la función primo se utiliza en la condición del if, 
    //pero no modifica el valor de n.

    //¿osea que es el if el que se da cuenta si primo devuelve true o false?

    //Exactamente, el if es el encargado de evaluar si la función primo devuelve true o
    //false. El if toma la decisión de ejecutar o no el bloque de código basándose en el valor 
    //retornado por la función primo. La expresión if (primo(n)) es una condición que se 
    //evalúa, y si esa condición es verdadera (es decir, si primo(n) devuelve true), entonces 
    //el bloque de código dentro del if se ejecuta. Si la condición es falsa (si primo(n)
    //devuelve false), el bloque del if no se ejecuta. En resumen, es el if el que decide
    //cómo actuar en función de si la función primo retorna true o false

    