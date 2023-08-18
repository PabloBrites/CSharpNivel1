using System;
using System.Reflection;
using System.Reflection.Metadata;

namespace forConfor
{
    class Program
    {
        static void Main(string[] args)
        {
            //for con for
            int prom, acu, n;
            for (int y = 0; y < 10; y++)
            {
                acu = 0;
                for (int x = 0; x < 20; x++)
                {
                    Console.WriteLine("Ingrese la edad: ");
                    n = int.Parse(Console.ReadLine());
                    acu += n;
                }
                prom = acu /20;
                Console.WriteLine("El promedio es : " + prom);
            }
        }
    }
}

// la cantidad de equipos la va a designar el ciclo externo, en este caso son 10 equipos. y < 10.
// como funciona este ciclo combinado? este ciclo sirve para cargar datos agrupados, supongamos que queremos cargar 
// sueldos, o supongamos que queremos cargar las edades de todos los equipos de todos los jugadores de futbol de primera.
// digamos como ejemplo que 20 personas for (int x = 0; x < 20; x++) son las que conforman el plantel de boca, de river,
// de racing etc.

// Entonces, arranca y encuentra un ciclo y dice bueno tengo que dar Diez vueltas for (int y = 0; y < 10; y++) este ciclo
// va a ser el que dirija al ciclo interno que es el que va a pedir 20 ingresos.
// empieza la primera vuelta, e inicializa el acumulador en cero acu = 0;
// agarra y dice che !otro ciclo¡ for (int x = 0; x < 20; x++) fijate que las variables son distintas, las variables en 
// los ciclos no pueden ser iguales.
// una vez que se choca con el ciclo interno empieza a pedir datos:    Console.WriteLine("Ingrese la edad: ");
                                                                    // n = int.Parse(Console.ReadLine());
                                                                    // acu += n;
                                                                    
// por cada vuelta que da, que en total son 20, pide datos, osea pide edad y acumula, pide edad y acumula 
// y asi hasta n-1, 
// una vez que termina, divide el acumulador por la cantidad de personas en este caso 20, que son las 
// que conforman un equipo, por eso el segundo ciclo da 20 vueltas porque por cada vuelta se ingresa la edad de una 
// persona que integra el equipo. y el resultado se agrega a la variable prom. prom = acu /20;
// y luego te muestra el promedio Console.WriteLine("El promedio es : " + prom);
// y llega al final.
// una vez que llega al final, itera, se produce el incremento, la variable (y) que estaba en cero pasa a estar en
// uno, si la condicion es verdadera entra, el acumulador vuelve a estar en cero, y asi sigue sucesivamente hasta que
// el ciclo externo de las diez vueltas. 