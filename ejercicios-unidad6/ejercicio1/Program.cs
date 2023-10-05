using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Hacer un programa para ingresar 10 números. El mismo debe analizar y mostrar por pantalla cuántos de esos 
            //números son primos.
            
            int n, con, conPrimo = 0;
           
            for (int i = 0; i < 5; i++)
            {   
                Console.WriteLine("Ingrese un numero: ");
                n = int.Parse(Console.ReadLine());

                con = 0;
                for (int x = 2; x < n; x++)
                {
                    if(n % x == 0)
                    con++;

                }
                if(con == 0)
                    conPrimo++;
                
            } 
            Console.WriteLine("La cantidad de primos es: " + conPrimo);
        }
    }
}
        //se pide un numero, inicializa el contador, y se pregunta si if(n % x == 0) si se encuentra algun divisor 
        // el contador va a sumar 1 y el contador de primos no va a sumar nada, llega hasta el final se vuelve a ingresar
        // otro numero y se vuelve a preguntar si if(n % x == 0) si en todas las vueltas que da el ciclo interno no se 
        //encuentra ningun divisor significa que ese numero solo es divisible por 1 y por si mismo entonces el contador 
        //en esta vuelta va a quedar en cero y cuando salga del ciclo interno y pregunte if(con == 0) a conPrimo se le 
        //va a sumar 1 y al final mostras cuantos numeros sumo conPrimo.