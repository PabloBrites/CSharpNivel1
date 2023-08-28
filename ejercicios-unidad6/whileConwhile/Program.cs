using System;

namespace whileConwhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, acu, con, prom;

            Console.WriteLine("Ingrese la edad: ");
            n = int.Parse(Console.ReadLine());
            while(n > 0){
                
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

                Console.WriteLine("Ingrese la edad para continuar o un negativo para cortar:");
                n = int.Parse(Console.ReadLine());
            }
        }
    }
}
            //como funciona?

            //vas a cargar una edad positiva,vas a cargar las edades de las personas hasta que cargues un cero y cuando
            //cargues un cero va a cortar ese equipo de futbol, va a calcular el promedio para ese equipo, te va a volver
            //a pedir para ver si queres cargar otro nuevo equipo y si cargas un numero mayor a cero va a volver a empezar
            // y si es un negativo o cero va a cortar.