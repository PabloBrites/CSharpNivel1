using System;
using System.Diagnostics;
using System.Timers;

namespace forConwhile
{
    class Program
    {
        static void Main(string[] args)
        {   
            int n, acu, con, prom;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese la edad: ");
                n = int.Parse(Console.ReadLine());
                acu = 0;
                con = 0;
                while (n != 0){

                    acu += n;
                    con++;
                    Console.WriteLine("Ingrese la edad: ");
                    n = int.Parse(Console.ReadLine());
                }
                prom = acu / con;
                Console.WriteLine("El promedio es: " + prom);
            }       
        }   
    }
}


// en este ciclo no vamos a saber la cantidad de personas que conforman el equipo, en el ciclo anterior sabiamos que 
// habia 10 equipos de 20 personas cada uno, en donde en cada vuelta ibamos pidiendo la edad, en este caso no vamos a 
// saber cuantas personas conforman el equipo, si vamos a cargar los 10 equipos con un for, pero no se cuantas personas
// conforman al equipo.

// en este programa vamos a cargar edades de personas hasta que me cargues una edad cero, while (n != 0)
// osea mientras n sea distinto de cero vamos a seguir pidiendo la edad.
// luego voy a necesitar calcular un promedio, entonces por cada persona vamos a acumular la edad, acu += n;
// creamos la variable (acu) e inicializamos la variable fuera del ciclo interno en cero acu = 0;
// adentro del ciclo while vamos a ir acumulando y va a cortar cuando se ingrese un cero.
// ¿ahora bien? cuantas personas son? porque el promedio es la cantidad sumada dividido la cantidad de personas, en el
// ciclo anterior sabiamos cuantas personas por equipo teniamos eran 20, pero aca no sabemos cuantas son entonces
// necesitamos un contador, creamos la variable (con) e inicializamos la variable con = 0; y contamos con con++
// luego para sacar el promedio lo que acumulo el acumulador lo dividimos por la cantidad que sumo el contador 
// prom = acu / con;
// y muestro el promedio.

// entonces para resumir...

// empieza la primera vuelta en cero for (int i = 0; i < 10; i++)  
// pedimos la edad Console.WriteLine("Ingrese la edad: ");
// inicializo acumulador acu = 0;
// inicializo contador con = 0;
// mientras la edad sea distinta de cero while(n != 0)
// acumulo, cuento, pido, acumulo, cuento, pido.                acu += n;
                                                               //con++;
                                                               //Console.WriteLine("Ingrese la edad: ");
// cuando el usuario ingresa cero termina el ciclo 
// calcula prom = acu / con;
// muestra el promedio Console.WriteLine("El promedio es: " + prom);
// llega al final
// y empieza denuevo pero i valiendo 1, asi hasta n-1 for (int i = 0; i < 10; i++)

// esto nos va a permitir cargar un lote completo de datos subdividido internamente en diez sublotes o subgrupos de
// datos, cada subgrupo en este caso va a corresponder a los equipos, pero el lote total va a ser el lote total de edades
// de la liga de futbol.



