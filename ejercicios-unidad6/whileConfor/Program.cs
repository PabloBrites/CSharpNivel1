using System;

namespace whileConfor
{
    class Program
    {
        static void Main(string[] args)
        {   
            int n, acu, prom;

            Console.WriteLine("Ingrese 1 para comenzar a preocesar o 0 para terminar");
            n = int.Parse(Console.ReadLine());
            while(n != 0){
                acu = 0;
                for (int x = 0; x < 20; x++)
                {
                    Console.WriteLine("Ingrese la edad: ");
                    n = int.Parse(Console.ReadLine());
                    acu += n;
                }
                prom = acu /20;
                Console.WriteLine("El promedio es : " + prom);
                Console.WriteLine("Ingrese 1 para continuar o 0 para terminar");
                n = int.Parse(Console.ReadLine());
            }
        }   
    }
}

// En este programa no vamos a saber la cantidad de equipos que tenemos o que vamos a cargar, el usuario debe poder cargar
// 5 equipos o 4 o 3 o lo que el usuario quiera, y cortar la carga en el momento que quiera una vez que termine de cargar
// la cantidad de personas que van a conformar cada equipo son 20, osea que si el usuario entra va a tener que cargar 20
// edades.

// para entenderlo mejor...

//arranca el programa con Console.writeline("ingrese 1  bla bla) e ingresas n.
//entra el ciclo while(n != 0)
//adentro del ciclo te pide la edad Console.WriteLine("Ingrese la edad: ");
//                                  n = int.Parse(Console.ReadLine());
//acumula                           acu += n;
//saca el promedio prom = acu /20;
//te muestra el promedio Console.WriteLine("El promedio es : " + prom); 
//y despues te dice che.. ingresa 1 para cargar otro grupo de 20 o cero para terminar
// si llegas a cargar 1 te vuelve a pedir un equipo completo de 20 personas
// y si ingresaste un cero termina de ejecutar

 